using Models.Generics;
using Models.Generics.ValueObjects;
using System.Diagnostics.Contracts;
using System.Collections.Generic;

namespace Models.Common.Subject
{
    /*
     * Basic subject scheleton - Name and credits
     */
    public abstract class Subjects : Entity<PlainText>
    {
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Subjects(PlainText name, Credits credits) : base(name)
        {
            Contract.Requires(name != null, "Name is null!");
            Contract.Requires(credits != null, "Credits is null!");

            Name = name;
            Credits = credits;
        }
    }
}
