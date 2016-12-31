using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.EventHandler
{
    public class ItemDeletedEventHandler : IEventHandler<ItemDeletedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemDeletedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemDeletedEvent handle)
        {
            _reportDatabase.Delete(handle.AggregateId);
        }
    }
}
