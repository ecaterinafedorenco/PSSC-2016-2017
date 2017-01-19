<<<<<<< HEAD:PSSC/Models/Contexts/Deanship/IReportPublisher.cs
﻿using Models.Generics.ValueObjects;
using System;
=======
﻿using Models.Generics;
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c:PSSC/Models/Deanship/IReportPublisher.cs
using System.Collections.Generic;

namespace Models.Contexts.Deanship
{
    //Strategy Signature
    public interface IReportStrategy
    {
        PlainText GenerateReport(List<Common.Student.Student> students);
    }

    //Strategy Context
    public interface IReportPublisher
    {
        void Publish(IReportStrategy strategy);
    }

}
