using Models.Common.Subject;
using Models.Generics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Deanship
{
    //Aggregate Root
    public class StudyYear
    {
        private List<Subject> _definedSubjects;
        public ReadOnlyCollection<Subject> Subjects { get { return _definedSubjects.AsReadOnly(); } }

        public StudyYear()
        {

        }

        public StudyYear(List<Subject> definedSubjects)
        {
            _definedSubjects = definedSubjects;
        }

        public void DefineSubject(PlainText subjectName, Credits credits, EvaluationType type, Proportion activity)
        {
            _definedSubjects.Add(new Subject(new SubjectInformation(subjectName, credits, type, activity)));
        }

        public void DefineSubject(PlainText subjectName, Credits credits, EvaluationType type, Proportion activity, Common.Professor.Professor professor)
        {
            _definedSubjects.Add(new Subject(new SubjectInformation(subjectName, credits, type, activity, professor)));
        }

        public void SignUpStudentToSubject(PlainText subjectName, Common.Student.Student student)
        {
            _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).SignUpStudent(student);
        }

        public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            return _definedSubjects.Find(d => d.SubjectInfo.Name == subjectName).GetAverageForStudent(regNumber);
        }

        public void PublishGradeReports(IReportPublisher publisher)
        {

        }
    }
}
