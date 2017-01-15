using CQRS.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.EventHandler
{
    public class DeletedEventHandler : IEventHandler<DeletedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public DeletedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(DeletedEvent handle)
        {
            _reportDatabase.Delete(handle.AggregateId);
        }
    }
}
