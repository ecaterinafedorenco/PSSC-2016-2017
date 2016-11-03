using Models.Common.Subject;
using Models.Generics;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Deanship
{
    //Aggregate Root
    public class StudyYear : Entity<Guid>
    {
        private HashSet<DefinedSubject> _definedSubjects;
        public ReadOnlyCollection<DefinedSubject> Subjects { get { return _definedSubjects.ToList().AsReadOnly(); } }

        private StudyYear(Guid id) : base(id)
        {

        }

        private StudyYear() : base(Guid.NewGuid())
        {

        }

        public StudyYear(Guid id, HashSet<DefinedSubject> definedSubjects) : this(id)
        {
            _definedSubjects = definedSubjects;
        }

        public StudyYear(HashSet<DefinedSubject> definedSubjects) : this()
        {
            _definedSubjects = definedSubjects;
        }

        public void DefineSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType type, Common.Professor.Professor professor, Proportion activity)
        {
            _definedSubjects.Add(new DefinedSubject(subjectName, credits, enrolledStudents, type, professor, activity));
        }

        public void DefineSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType type, Common.Professor.Professor professor)
        {
            _definedSubjects.Add(new DefinedSubject(subjectName, credits, enrolledStudents, type, professor));
        }

        public void EnrollStudentToSubject(PlainText subjectName, Common.Student.Student student)
        {
            _definedSubjects.First(d => d.Name == subjectName).EnrollStudent(student);
        }

        public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            return _definedSubjects.First(d => d.Name == subjectName).GetStudentAverage(regNumber);
        }

        public ViewableSituation GetStudentSituation(PlainText subjectName, RegistrationNumber regNumber)
        {
            return _definedSubjects.First(d => d.Name == subjectName).GetStudentSituation(regNumber);
        }
    }
}
