using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands
{
    public class Command
    {
        public Guid Id { get; private set; }
        public Command(Guid id)
        {
            Id = id;
        }
    }
}
