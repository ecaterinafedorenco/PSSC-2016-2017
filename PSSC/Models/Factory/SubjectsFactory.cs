using Models.Generics;
using Models.Generics.Exceptions;
using Models.Subject;
using System.Diagnostics.Contracts;

namespace Models.Factory
{
    // Creates a SubjectsFactory instance
    public class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();

        private SubjectsFactory()
        { }

        // Creates a Subject instance
        public Subject.Subject createInstance(Subject.SubjectInformation subjectInformation)
        {
            Contract.Requires<SubjectDublicateException>(subjectInformation.Name != null, "Argument cannont be null");
            Subject.Subject subject = new Subject.Subject(subjectInformation);

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
