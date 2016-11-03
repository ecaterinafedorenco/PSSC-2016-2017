using Models.Generics;
using Models.Generics.ValueObjects;

namespace Models.Common.Subject
{
    public abstract class Subject : Entity<PlainText>
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Subject(PlainText name, Credits credits) : base(name)
        {
            Name = name;
            Credits = credits;
        }
    }
}
