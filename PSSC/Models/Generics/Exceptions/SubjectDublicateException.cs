using System;

namespace Models.Generics.Exceptions
{
    public class SubjectDublicateException : ArgumentException
    {
        public SubjectDublicateException(string message)
            : base(message)
        {
            if (message == null)
            {
                throw new ArgumentException("A subject with a given name already exists!");
            }
        }
    }
}
