using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    /*
     * Why implement IEquatable? - http://stackoverflow.com/questions/2476793/when-to-use-iequatable-and-why
     * 1. Performance boost for generic collection objects functions (Contains, IndexOf, etc...)
     * 2. No boxing
     * 
     * What should a base entity class contain?
     * 1. The Id of course (Table key)
     * 2. Common logic
     */

    public abstract class Entity<T> : IEquatable<T>
    {
        public T Id { get; protected set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(T other)
        {
            return Id.Equals(other);
        }
    }
}
