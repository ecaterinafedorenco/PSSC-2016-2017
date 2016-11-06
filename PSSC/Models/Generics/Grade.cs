using System;
using System.Diagnostics.Contracts;

namespace Models.Generics
{
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        public Grade(decimal value)
        {
            Contract.Requires<ArgumentException>(value > 0, "Grade value cannot be < 0!");
            _value = value;
        }
    }
}
