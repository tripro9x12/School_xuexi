using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Dtos
{
    public class RegisterAccountDto
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        [DataType(DataType.Password)]
        [Compare("PassWord")]
        public string ConfirmPassWord { get; set; }
    }
}
