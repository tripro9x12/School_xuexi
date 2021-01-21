using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Dtos
{
    public class UpdatePeopleDto : CreatePeopleDto
    {
        public int Id { get; set; }
    }
}
