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
        private List<DefinableSubject> _definedSubjects;
        public ReadOnlyCollection<DefinableSubject> Subjects { get { return _definedSubjects.AsReadOnly(); } }

        public StudyYear()
        {

        }

        public StudyYear(List<DefinableSubject> definedSubjects)
        {
            _definedSubjects = definedSubjects;
        }

        public void DefineSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents, 
            EvaluationType type, Common.Professor.Professor professor, Proportion activity)
        {
            _definedSubjects.Add(new DefinableSubject(subjectName, credits, enrolledStudents, type, professor, activity));
        }

        public void DefineSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType type, Common.Professor.Professor professor)
        {
            _definedSubjects.Add(new DefinableSubject(subjectName, credits, enrolledStudents, type, professor));
        }

        public void EnrollStudentToSubject(PlainText subjectName, Common.Student.Student student)
        {
            _definedSubjects.Find(d => d.Name == subjectName).EnrollStudent(student);
        }

        public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            return _definedSubjects.Find(d => d.Name == subjectName).GetStudentAverage(regNumber);
        }
        
        public ViewableSituation GetStudentSituation(PlainText subjectName, RegistrationNumber regNumber)
        {
            return _definedSubjects.Find(d => d.Name == subjectName).GetStudentSituation(regNumber);
        }

        public void PublishGradeReports(IReportPublisher publisher)
        {

        }
    }
}
