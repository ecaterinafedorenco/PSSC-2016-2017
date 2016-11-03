using Models.Generics.ValueObjects;

namespace Models.Common.Subject
{
    public abstract class Subject
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Subject()
        {

        }

        public Subject(PlainText name, Credits credits)
        {
            Name = name;
            Credits = credits;
        }
    }
}
