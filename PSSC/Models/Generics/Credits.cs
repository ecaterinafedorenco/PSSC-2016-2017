using System;
using System.Diagnostics.Contracts;

namespace Models.Generics
{
    public class Credits
    {
        private const int _maxCredits = 60;
        public static int MAX { get { return _maxCredits; } }

        private int _credits;
        public int Count { get { return _credits; } set { _credits = value; } }

        public Credits()
        {
        }

        public Credits(int credits)
        {
            Contract.Requires<ArgumentException>(credits > 0, "Credits value cannot be < 0!");
            _credits = credits;
        }
    }
}
