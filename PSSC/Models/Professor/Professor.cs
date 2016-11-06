using Models.Generics;
using System;

namespace Models.Professor
{
    //Entity
    public class Professor
    {
        public Guid GetId { get; internal set; }
        public PlainText Name { get; internal set; }

        public Professor(Guid getId, PlainText name)
        {
            GetId = getId;
            Name = name;
        }
    }
}
