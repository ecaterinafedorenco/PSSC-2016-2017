using System;
using System.Diagnostics.Contracts;

namespace Models.Generics
{
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
            Contract.Requires<ArgumentNullException>(number != null, "regNumber");
            Contract.Requires<ArgumentException>(number.Length == 4, "Registration number has 4 characters.");
            _number = number;
        }
    }
}
