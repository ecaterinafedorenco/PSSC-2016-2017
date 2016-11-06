using Models.Generics;
using System;

namespace Models.Student
{
    //Entity
    public class Student
    {
        public Guid GetId { get; internal set; }
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Student(Guid getId, RegistrationNumber regNumber, PlainText name)
        {
            GetId = getId;
            RegNumber = regNumber;
            Name = name;
        }

        public Student(Guid getId, RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(getId, regNumber, name)
        {
            Credits = credits;
        }
    }
}
