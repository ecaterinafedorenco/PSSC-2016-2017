﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.Exceptions
{
    public class InvalidCreditsValue : Exception
    {
        Credits credits;
        public InvalidCreditsValue(string message)
            : base(message)
        {
            if (credits.Count < 0)
            {
                throw new ArgumentException("Invalid Credits Value");
            }
        }
    }
}
