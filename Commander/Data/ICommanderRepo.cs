using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        // returns a collection of Command
        IEnumerable<Command> GetAllCommands();

        // returns a single Command
        Command GetCommandById(int id);

        // Creating a command 
        void CreateCommand(Command cmd);

        bool Save();
    }
}