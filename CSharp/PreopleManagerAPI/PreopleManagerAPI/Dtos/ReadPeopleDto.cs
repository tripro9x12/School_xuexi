using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Dtos
{
    public class ReadPeopleDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Dob { get; set; }
        public string CountryName { get; set; }
    }
}
