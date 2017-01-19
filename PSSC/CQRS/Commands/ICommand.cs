using System;

namespace CQRS.Commands
{
    public class ICommand
    {
<<<<<<< HEAD:PSSC/CQRS/Commands/ICommand.cs
        Guid Id { get; }
=======
        Credits credits;
        public InvalidCreditsValue(string message)
            : base(message)
        {
            if (credits.Count < 0)
            {
                throw new ArgumentException("Invalid Credits Value");
            }
        }
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Generics/Exceptions/InvalidCreditsValue.cs
    }
}
