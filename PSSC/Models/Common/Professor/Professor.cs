using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Professor
{
    //Entity
    public class Professor
    {
        public PlainText Name { get; internal set; }

        public Professor(PlainText name)
        {
            Name = name;
        }
    }
}
