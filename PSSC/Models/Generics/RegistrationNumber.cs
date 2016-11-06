using System;
using System.Diagnostics.Contracts;

namespace Models.Generics
{
    // Registration number for student (example: 8642)
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
            Contract.Requires<ArgumentNullException>(number != null, "Registration number cannot be null!");
            Contract.Requires<ArgumentException>(number.Length == 4, "Registration number has 4 characters.");
            _number = number;
        }
    }
}
