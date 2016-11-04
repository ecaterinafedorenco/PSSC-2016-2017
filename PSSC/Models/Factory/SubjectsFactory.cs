using Models.Generics;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Factory
{
    public class SubjectsFactory
    {
        public static readonly SubjectsFactory Instance = new SubjectsFactory();
        private Proportion activity;
        private Credits credits;
        private PlainText name;
        private EvaluationType type;

        public SubjectsFactory()
        { }

        public Subject.Subject createInstance(SubjectInformation subjectInformation)
        {
            //Contract.Requires<ArgumentNullException>(subjectInformation.Name != null, "text");
            //Contract.Requires<ArgumentNullException>(subjectInformation.Professor.Name != null,
            //    "Professor name should not be null.");
            //Contract.Requires<ArgumentNullException>(subjectInformation.Credits != null,
            //    "Professor name should not be null.");

            Subject.Subject subject = new Subject.Subject(new Subject.SubjectInformation(
                name, credits, type, activity));

            return subject;
        }

        public SubjectSituation subjectSituation(int count, decimal value)
        {
            return new SubjectSituation(
                                new Attendance(count),
                                new Grade(value));
        }

        public Student.Student createStudnet(Guid id, string regNumber, string name)
        {
            return new Student.Student(id, new RegistrationNumber(regNumber), new PlainText(name));
        }
    }
}
