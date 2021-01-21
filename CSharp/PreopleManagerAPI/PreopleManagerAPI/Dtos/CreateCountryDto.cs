using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Dtos
{
    public class CreateCountryDto
    {
        [Required]
        public string CountryName { get; set; }
    }
}
