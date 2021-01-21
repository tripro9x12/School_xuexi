using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PreopleManagerAPI.Models.Entities;
using PreopleManagerAPI.Dtos;

namespace PreopleManagerAPI.Data
{
    public interface IPeopleRepository
    {
        void CreatePeople(People model);
        void UpdatePeople(People model);
        void DeletePeople(People model);
        ReadPeopleDto GetPeopleDto(int id);
        People GetPeople(int id);
        IEnumerable<ReadPeopleDto> GetReadPeopleDtos();
    }
}
