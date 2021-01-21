using PreopleManagerAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreopleManagerAPI.Data
{
    public interface ICountryRepository
    {
        void CreateCountry(Country model);
        void UpdateCountry(Country model);
        void DeleteCountry(Country model);
        Country GetCountry(int id);
        IEnumerable<Country> GetCountries();

    }
}
