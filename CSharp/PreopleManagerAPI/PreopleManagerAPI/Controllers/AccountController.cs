using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PreopleManagerAPI.Models.Identities;
using AutoMapper;
using PreopleManagerAPI.Dtos;
using PreopleManagerAPI.Models.Account;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace PreopleManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<AppUser> userManager, 
                                SignInManager<AppUser> signInManager,
                                IMapper mapper,
                                IConfiguration configuration)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._mapper = mapper;
            this._configuration = configuration;
        }
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<ReadAccountDto>> RegisterAccount(RegisterAccountDto registerAccountModel)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser()
                {
                    Email = registerAccountModel.Email,
                    UserName = registerAccountModel.Email,
                    Address = registerAccountModel.Address,
                    FullName = registerAccountModel.FullName
                };
                var result = await _userManager.CreateAsync(user: user, password: registerAccountModel.PassWord);
                if (result.Succeeded)
                {
                    var readAccount = _mapper.Map<ReadAccountDto>(user);
                    return Ok(readAccount);
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return NotFound();
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUser model)
        {
            if (ModelState.IsValid)
            {
                var token = await GenerateToken(model);
                return Ok(new { token });
            }
            return NotFound();
        }
        public async Task<string> GenerateToken(LoginUser model)
        {
            var result = await _signInManager.PasswordSignInAsync(
                                                userName: model.Email,
                                                password: model.PassWord,
                                                isPersistent: model.RememberMe,
                                                lockoutOnFailure: false
                                              );
            if (result.Succeeded)
            {
                var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Authentication:SecretKey"]));
                var signingCredentials = new SigningCredentials(symmetricSecurityKey,SecurityAlgorithms.HmacSha256);

                var user = await _userManager.FindByNameAsync(model.Email);
                var claims = new[]
                {
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim(ClaimTypes.Email, user.Email),
                //new Claim(ClaimTypes.Role, user)
                };
                var token = new JwtSecurityToken(
                    issuer: _configuration["Authentication:Issuer"],
                    audience: _configuration["Authentication:Audience"],
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: signingCredentials,
                    claims: claims                    
                );
                return new JwtSecurityTokenHandler().WriteToken(token);
              
            }
            return "Invalid Login Attemp";
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok("logout success");
        }

        [HttpPost]
        [Route("changepassword")]
        public async Task<IActionResult> ChangePassword(ChangePassword changePasswordModel)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId);
            var result = await _userManager.ChangePasswordAsync(user, changePasswordModel.oldPassWord, changePasswordModel.newPassWord);
            if(result == null)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(" ", error.Description);
                }
                return NotFound();
            }
            return Ok("changepassword success");
        }

    }
}
