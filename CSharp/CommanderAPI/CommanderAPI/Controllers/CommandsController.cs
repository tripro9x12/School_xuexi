using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommanderAPI.Data;
using CommanderAPI.Models;
using AutoMapper;
using CommanderAPI.Dtos;

namespace CommanderAPI.Controllers
{
    //[Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepository mockCommanderRepository;
        private readonly IMapper mapper;

        public CommandsController(ICommanderRepository _mockCommanderRepository, IMapper _mapper)
        {
            mockCommanderRepository = _mockCommanderRepository;
            this.mapper = _mapper;
        }
        [HttpGet]
        [Route("api/commands/gets")]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commands = mockCommanderRepository.GetCommands().ToList();
            return Ok(mapper.Map<IEnumerable<CommandReadDto>>(commands));
        }

        [HttpGet]
        [Route("api/commands/get/{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id)
        {
            var command = mockCommanderRepository.GetCommandById(id);
            if (command != null)
            {
                return Ok(mapper.Map<CommandReadDto>(command));
            }
            return NotFound();

        }
        [HttpPost]
        [Route("api/commands/create")]
        public ActionResult<CommandReadDto> CreateCommand(CommandCreateDto commandModel)
        {
            var model = mapper.Map<Command>(commandModel);
            mockCommanderRepository.CreateCommand(model);

            var commandReadDto = mapper.Map<CommandReadDto>(model);
            return Ok(commandReadDto);
        }

        [HttpPut]
        [Route("api/commands/update/{id}")]
        public ActionResult<CommandReadDto> UpdateCommand(int id, CommandUpdateDto commandModel)
        {
            var model = mockCommanderRepository.GetCommandById(id);
            if(model == null)
            {
                return NotFound();
            }
            mapper.Map(commandModel, model);
            mockCommanderRepository.UpdateCommand(model);

            //return NoContent();
            var commandReadDto = mapper.Map<CommandReadDto>(model);
            return Ok(commandReadDto);
        }
        [HttpDelete]
        [Route("api/commands/delete/{id}")]
        public ActionResult<CommandReadDto> DeleteCommand(int id)
        {
            var model = mockCommanderRepository.GetCommandById(id);
            if(model == null)
            {
                return NotFound();
            }
            mockCommanderRepository.DeleteCommand(model);
            return NoContent();
        }
    }
}
