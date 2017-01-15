using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Generics.ValueObjects;

namespace CQRS.Events
{
    public class CreatedEvent : Event
    {
        public int Credits { get; internal set; }
        public string Name { get; internal set; }

        public CreatedEvent(Guid aggregateId, string name, int credits)
        {
            AggregateId = aggregateId;
            Name = name;
            Credits = credits;
        }
    }
}
