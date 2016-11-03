using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    public class Attendance
    {
        private DateTime _date;
        public int Date { get; internal set; }

        public Attendance(DateTime date)
        {
            _date = date;
        }
    }
}
