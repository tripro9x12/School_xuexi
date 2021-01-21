using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Models.Account
{
    public class LoginUser
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
        public bool RememberMe { get; set; }
    }
}
