using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Commands
{
    public class ChangeCommand : Command
    {
        public string Name { get; internal set; }
        public int Credits { get; internal set; }
        public DateTime To { get; internal set; }

        public ChangeCommand(Guid aggregateId, string name, int credits)
        : base(aggregateId)
        {
            Name = name;
            Credits = credits;
        }
    }
}
