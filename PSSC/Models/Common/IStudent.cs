using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common
{
    public interface IStudent
    {
        RegistrationNumber RegNumber { get; set; }
        PlainText Name { get; set; }
    }
}
