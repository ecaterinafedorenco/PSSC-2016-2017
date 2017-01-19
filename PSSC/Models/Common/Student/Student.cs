using Models.Generics;
using Models.Generics.ValueObjects;
using System;
<<<<<<< HEAD:PSSC/Models/Common/Student/Student.cs
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Student/Student.cs

namespace Models.Common.Student
{
    /*
     * Entity which describes a 'student':
     * 1. Registration number
     * 2. Name
     * 3. Accumulated credits
     */
    public class Student : Entity<RegistrationNumber>
    {
        public Guid GetId { get; internal set; }
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

<<<<<<< HEAD:PSSC/Models/Common/Student/Student.cs
        public Student(RegistrationNumber regNumber, PlainText name) : base(regNumber)
        {
            Contract.Requires(regNumber != null, "Registration number is null!");
            Contract.Requires(name != null, "Student name is null!");

=======
        public Student(Guid getId, RegistrationNumber regNumber, PlainText name)
        {
            GetId = getId;
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Student/Student.cs
            RegNumber = regNumber;
            Name = name;
        }

        public Student(Guid getId, RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(getId, regNumber, name)
        {
            Contract.Requires(credits != null, "Credits is null!");

            Credits = credits;
        }
    }
}
