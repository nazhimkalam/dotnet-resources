using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
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
    }
}