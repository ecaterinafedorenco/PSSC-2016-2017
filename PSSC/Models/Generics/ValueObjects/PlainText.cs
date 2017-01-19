using System;
<<<<<<< HEAD:PSSC/Models/Generics/ValueObjects/PlainText.cs
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
using System.Diagnostics.Contracts;
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Generics/PlainText.cs

namespace Models.Generics.ValueObjects
{
    /*
     * Used to describe a plain text string
     */
    public class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
<<<<<<< HEAD:PSSC/Models/Generics/ValueObjects/PlainText.cs
            Contract.Requires<ArgumentException>(text.Length >= 2 && text.Length <= 50, "Invalid plain text length!");

=======
            Contract.Requires<ArgumentCannotBeEmptyStringException>(text != null, "Argument cannont be null");
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Generics/PlainText.cs
            _text = text;
        }
    }
}
