using System;
<<<<<<< HEAD:PSSC/Models/Generics/ValueObjects/RegistrationNumber.cs
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.Diagnostics.Contracts;
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Generics/RegistrationNumber.cs

namespace Models.Generics.ValueObjects
{
<<<<<<< HEAD:PSSC/Models/Generics/ValueObjects/RegistrationNumber.cs
    /*
     * Used as an unique identifier for students
     */
=======
    // Registration number for student (example: 8642)
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Generics/RegistrationNumber.cs
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
<<<<<<< HEAD:PSSC/Models/Generics/ValueObjects/RegistrationNumber.cs
            Contract.Requires(number.Length > 3 && number.Length <= 10, "Invalid registration number length!");

=======
            Contract.Requires<ArgumentNullException>(number != null, "Registration number cannot be null!");
            Contract.Requires<ArgumentException>(number.Length == 4, "Registration number has 4 characters.");
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Generics/RegistrationNumber.cs
            _number = number;
        }
    }
}
