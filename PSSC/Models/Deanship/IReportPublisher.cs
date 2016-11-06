using Models.Generics;
using System.Collections.Generic;

namespace Models.Deanship
{
    //Strategy Signature
    public interface IReportStrategy
    {
        PlainText GenerateReport(List<Student.Student> students);
    }

    //Strategy Context
    public interface IReportPublisher
    {
        void Publish(IReportStrategy strategy);
    }

}
