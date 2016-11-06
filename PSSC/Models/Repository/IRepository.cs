using System;
using System.Collections.Generic;

namespace Models.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(Guid Id);
    }
}
