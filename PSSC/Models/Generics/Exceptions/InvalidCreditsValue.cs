using System;

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
