using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.EventHandler
{
    public interface IReportDatabase
    {
        void Add(SubjectItem item);
        void Delete(object aggregateId);
    }
}
