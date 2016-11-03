using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common.Subject;
using Models.Generics.ValueObjects;

namespace Models.Contexts.Professor
{
    //Aggregate Root
    public class Subjects
    {
        private HashSet<TeachingSubject> _subjects { get; set; }
        public ReadOnlyCollection<TeachingSubject> AllSubjects { get { return _subjects.ToList().AsReadOnly(); } }

        public Subjects(HashSet<TeachingSubject> subjects)
        {
            _subjects = subjects;
        }

        public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.First(d => d.Name == subjectName)
                .AddExamGrade(regNumber, grade);
        }

        public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.First(d => d.Name == subjectName)
                .AddActivityGrade(regNumber, grade);
        }

        public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            _subjects.First(d => d.Name == subjectName)
                .AddAttendance(regNumber, attendance);
        }

        public void SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            _subjects.First(d => d.Name == subjectName).SetActivityProportion(proportion);
        }
    }
}
