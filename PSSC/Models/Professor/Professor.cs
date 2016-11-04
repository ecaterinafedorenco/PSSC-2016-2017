using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
