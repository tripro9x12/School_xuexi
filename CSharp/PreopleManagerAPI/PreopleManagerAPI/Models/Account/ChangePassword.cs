using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Models.Account
{
    public class ChangePassword
    {
        [DataType(DataType.Password)]
        public string oldPassWord { get; set; }
        [DataType(DataType.Password)]
        public string newPassWord { get; set; }
        [DataType(DataType.Password)]
        [Compare("newPassWord")]
        public string confirmNewPassWord { get; set; }
    }
}
