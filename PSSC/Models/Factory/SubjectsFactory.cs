using Models.Generics;
using Models.Subject;
using System.Collections.Generic;

namespace Models.Factory
{
    public class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();
        List<Subject.Subject> _subjects;
        int credits, type;
        private string name;

        public SubjectsFactory()
        { }

        public Subject.Subject createInstance(Subject.Subject subject)
        {
            subject = new Subject.Subject(new Subject.SubjectInformation(new PlainText(name), new Credits(credits),
                new EvaluationType(), new Proportion()));

            return subject;
        }

        public SubjectSituation subjectSituation(int count, decimal value)
        {
            return new SubjectSituation(
                                new Attendance(count),
                                new Grade(value));
        }
    }
}
