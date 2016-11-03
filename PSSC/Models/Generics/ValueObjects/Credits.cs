using Models.Generics.Exceptions;
using System.Diagnostics.Contracts;

namespace Models.Generics.ValueObjects
{
    public class Credits
    {
        private int _credits;
        public int Count { get { return _credits; } }

        public Credits(int credits)
        {
            Contract.Requires<InvalidCreditsValueException>(credits > 0 && credits < 15, "Invalid value for credits!");
            
            _credits = credits;
        }
    }
}
