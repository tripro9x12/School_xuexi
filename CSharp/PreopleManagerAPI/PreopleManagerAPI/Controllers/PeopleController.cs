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
using Microsoft.AspNetCore.Authorization;

namespace PreopleManagerAPI.Controllers
{
    [Authorize]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository _peopleRepository;
        private readonly IMapper _mapper;

        public PeopleController(IPeopleRepository peopleRepository,IMapper mapper)
        {
            this._peopleRepository = peopleRepository;
            this._mapper = mapper;
        }

        [HttpPost]
        [Route("api/people/create")]
        public ActionResult<ReadPeopleDto> CreatePeople(CreatePeopleDto peopleModel)
        {
            if (ModelState.IsValid)
            {
                var model = _mapper.Map<People>(peopleModel);
                _peopleRepository.CreatePeople(model);

                var readPeopleDto = _peopleRepository.GetPeopleDto(model.Id);
                return Ok(readPeopleDto);
            }
            return NotFound();
        }
        
        [HttpGet]
        [Route("api/people/get/{id}")]
        public ActionResult<ReadPeopleDto> GetPeopleById(int id)
        {
            var model = _peopleRepository.GetPeopleDto(id);
            if(model == null)
            {
                return NotFound();
            }
            return Ok(model);
        }

        [HttpGet]
        [Route("api/people/gets")]
        public ActionResult<ReadPeopleDto> GetPeoples()
        {
            var model = _peopleRepository.GetReadPeopleDtos();
            return Ok(model);
        }

        [HttpPut]
        [Route("api/people/update")]
        public ActionResult<ReadPeopleDto> UpdatePeople(UpdatePeopleDto PeopleModel)
        {
            var updatePeople = _mapper.Map<People>(PeopleModel);
            _peopleRepository.UpdatePeople(updatePeople);

            var readPeopleDto = _peopleRepository.GetPeopleDto(updatePeople.Id);
            return Ok(readPeopleDto);
        }

        [HttpDelete]
        [Route("api/people/delete/{id}")]
        public ActionResult<ReadPeopleDto> DeletePeople(int id)
        {
            var deletePeople = _peopleRepository.GetPeople(id);
            if(deletePeople == null)
            {
                return NotFound();
            }
            _peopleRepository.DeletePeople(deletePeople);
            return NoContent();
        }
    }
}
