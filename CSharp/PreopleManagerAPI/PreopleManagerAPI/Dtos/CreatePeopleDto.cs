using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Dtos
{
    public class CreatePeopleDto
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        public string CMT { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
