using PreopleManagerAPI.Models;
using PreopleManagerAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Data
{
    public class CountryRepository : ICountryRepository
    {
        private readonly AppDbContext _context;

        public CountryRepository(AppDbContext context)
        {
            this._context = context;
        }
        public void CreateCountry(Country model)
        {
            if(model != null)
            {
                _context.countries.Add(model);
                _context.SaveChanges();
            }
        }

        public void DeleteCountry(Country model)
        {
            if(model != null)
            {
                _context.countries.Remove(model);
            }
            _context.SaveChanges();
        }

        public IEnumerable<Country> GetCountries()
        {
            return _context.countries;
        }

        public Country GetCountry(int id)
        {
            var model = _context.countries.FirstOrDefault(c => c.CountryId == id);
            return model;
        }

        public void UpdateCountry(Country model)
        {
            _context.SaveChanges();
        }
    }
}
