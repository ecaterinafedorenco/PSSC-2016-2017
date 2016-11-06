using System;

namespace Models.Generics.Exceptions
{
    class ArgumentInvalidLengthException : ArgumentException
    {
        public ArgumentInvalidLengthException(string message)
            : base(message)
        {
            throw new ArgumentException("Invalid argument length!");

        }
    }
}
