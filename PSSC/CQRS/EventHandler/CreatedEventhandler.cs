using CQRS.Events;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.EventHandler
{
    public class CreatedEventHandler : IEventHandler<CreatedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public CreatedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(CreatedEvent handle)
        {
            SubjectItem item = new SubjectItem()
            {
                //Name = handle.Name;
                //Credits = handle.Credits;
            };

            _reportDatabase.Add(item);
        }
    }
}
