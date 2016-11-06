using System;

namespace Models.Repository.Exceptions
{
    public class SubjectDublicateException : ArgumentException
    {
        public SubjectDublicateException(string message)
            : base(message)
        {
            throw new ArgumentException("A subject with a given name already exists!");

        }
    }
}
