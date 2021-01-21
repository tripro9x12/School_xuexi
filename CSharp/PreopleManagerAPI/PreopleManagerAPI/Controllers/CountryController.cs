using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PreopleManagerAPI.Data;
using AutoMapper;
using PreopleManagerAPI.Dtos;
using PreopleManagerAPI.Models.Entities;

namespace PreopleManagerAPI.Controllers
{
    
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public CountryController(ICountryRepository countryRepository, IMapper mapper)
        {
            this._countryRepository = countryRepository;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("api/country/create")]
        public ActionResult<ReadCountryDto> CreateCountry(CreateCountryDto countryModel)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<Country>(countryModel);
                _countryRepository.CreateCountry(model);

                var readCountryDto = _mapper.Map<ReadCountryDto>(model);
                return Ok(model);
            }
            return NotFound();           
        }

        [HttpGet]
        [Route("api/country/get/{id}")]
        public ActionResult<ReadCountryDto> GetCountryById(int id)
        {
            var model = _countryRepository.GetCountry(id);
            if(model == null)
            {
                return NotFound();
            }
            var readCountryDto = _mapper.Map<ReadCountryDto>(model);
            return Ok(readCountryDto);
        }

        [HttpGet]
        [Route("api/country/gets")]
        public ActionResult<IEnumerable<ReadCountryDto>> GetCountries()
        {
            var models = _countryRepository.GetCountries().ToList();
            var readCountryDtos = _mapper.Map<IEnumerable<ReadCountryDto>>(models);

            return Ok(readCountryDtos);
        }

        [HttpPut]
        [Route("api/country/update/{id}")]
        public ActionResult<ReadCountryDto> UpdateCountry(int id, UpdateCountryDto countryModel)
        {
            var model = _countryRepository.GetCountry(id);
            if(model == null)
            {
                return NotFound();
            }
            _mapper.Map(countryModel, model);
            _countryRepository.UpdateCountry(model);

            var readCountryDto = _mapper.Map<ReadCountryDto>(model);
            return Ok(readCountryDto);
        }

        [HttpDelete]
        [Route("api/country/delete/{id}")]
        public ActionResult<ReadCountryDto> DeleteCountry(int id)
        {
            var model = _countryRepository.GetCountry(id);
            if(model == null)
            {
                return NotFound();
            }
            _countryRepository.DeleteCountry(model);
            return NoContent();
        }

    }
}
