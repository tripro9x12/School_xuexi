using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Models.Entities
{
    public class Country
    {
        [Required]
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
