using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Dtos
{
    public class ReadAccountDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}
