using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommanderAPI.Models;

namespace CommanderAPI.Data
{
    public interface ICommanderRepository
    {
        void CreateCommand(Command model);
        void UpdateCommand(Command model);
        void DeleteCommand(Command model);
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
        bool SaveChanges();
    }
}
