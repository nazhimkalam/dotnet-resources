using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        // returns a collection of Command
        IEnumerable<Command> GetAppCommands();

        // returns a single Command
        Command GetCommandById(int id);
    }
}