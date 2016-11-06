using System;

namespace Models.Generics
{
    internal class ArgumentCannotBeEmptyStringException : Exception
    {
        public ArgumentCannotBeEmptyStringException(string message)
            : base(message)
        {
            if (message == null)
            {
                throw new ArgumentException("Argument cannot be empty!");
            }
        }
    }
}