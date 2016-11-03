using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    //Possible 'description' field needed for activity grades (Test, Project)
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        private DateTime _date;
        public DateTime Date { get { return _date; } }

        public Grade(decimal value)
        {
            _value = value;
        }

        public Grade(DateTime date, decimal value)
        {
            _date = date;
            _value = value;
        }
    }
}
