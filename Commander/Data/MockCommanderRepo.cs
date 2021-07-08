using System.Collections.Generic;
using Commander.Models;

// This is a Mock Repo

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>()
            {
                new Command{Id = 0, HowTo="This is some random testing text", Line = "npm start", Platform = "Windows"},
                new Command{Id = 1, HowTo="This is some random testing text", Line = "npm dev", Platform = "Windows"},
                new Command{Id = 2, HowTo="This is some random testing text", Line = "npm server", Platform = "Windows"}
            };

            return commands;


        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo="This is some random testing text", Line = "npm start", Platform = "Windows"};
        }

        public bool Save()
        {
            throw new System.NotImplementedException();
        }
    }
}