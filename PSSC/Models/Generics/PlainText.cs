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
            Contract.Requires<ArgumentNullException>(text != null, "text");
            _text = text;
        }
    }
}
