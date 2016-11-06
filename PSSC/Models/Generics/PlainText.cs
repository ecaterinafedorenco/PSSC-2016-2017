using System;
using System.Diagnostics.Contracts;

namespace Models.Generics
{
    public class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
            Contract.Requires<ArgumentCannotBeEmptyStringException>(text != null, "Argument cannont be null");
            _text = text;
        }
    }
}
