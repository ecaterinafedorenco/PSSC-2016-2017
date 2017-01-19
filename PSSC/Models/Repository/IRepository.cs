using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common.Subject;
=======
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c

namespace Models.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(Guid Id);
<<<<<<< HEAD
        void Save(Subjects aggregate);
=======
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
    }
}
