
using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly MockCommanderRepo _repo = new MockCommanderRepo();
        // This is to get all eg: api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var allCommandItems = _repo.GetAppCommands();
            return Ok(allCommandItems);
        }

        // This is for the route which expects an "id" eg: api/commands/1
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repo.GetCommandById(id);
            return Ok(commandItem);
        }

    }
}