using CommanderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data
{
    public class MockCommanderRepository : ICommanderRepository
    {
        private readonly CommanderContext _context;

        public MockCommanderRepository(CommanderContext context)
        {
            this._context = context;
        }

        public void CreateCommand(Command model)
        {
            if(model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.commands.Add(model);
            SaveChanges();
        }

        public void DeleteCommand(Command model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }
            _context.commands.Remove(model);
            SaveChanges();
        }

        public Command GetCommandById(int id)
        {
            return GetCommands().FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Command> GetCommands()
        {
            return _context.commands.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCommand(Command model)
        {
            SaveChanges();
        }
    }
}
