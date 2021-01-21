using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PreopleManagerAPI.Data;
using PreopleManagerAPI.Dtos;
using PreopleManagerAPI.Models;
using PreopleManagerAPI.Models.Entities;

namespace PreopleManagerAPI.Data
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly AppDbContext _context;

        public PeopleRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void CreatePeople(People model)
        {
            if(model != null)
            {
                _context.peoples.Add(model);
            }
            _context.SaveChanges();
        }

        public void DeletePeople(People model)
        {
            _context.peoples.Remove(model);
            _context.SaveChanges();
        }

        public People GetPeople(int id)
        {
            return _context.peoples.FirstOrDefault(p => p.Id == id);
        }

        public ReadPeopleDto GetPeopleDto(int id)
        {
            return GetReadPeopleDtos().FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<ReadPeopleDto> GetReadPeopleDtos()
        {
            var models = (from p in _context.peoples
                          join c in _context.countries on p.CountryId equals c.CountryId
                          select new ReadPeopleDto()
                          {
                              Id = p.Id,
                              Dob = p.Dob,
                              FullName = p.FullName,
                              CountryName = c.CountryName
                          }).ToList();
            return models;
        }

        public void UpdatePeople(People model)
        {
            var updatePeople = _context.peoples.Attach(model);
            updatePeople.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
