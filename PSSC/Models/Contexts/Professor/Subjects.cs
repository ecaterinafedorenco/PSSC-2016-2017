using Models.Generics;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common.Subject;

namespace Models.Contexts.Professor
{
    //Aggregate Root
    public class Subjects
    {
        private List<TeachingSubject> _subjects { get; set; }
        public ReadOnlyCollection<TeachingSubject> AllSubjects { get { return _subjects.AsReadOnly(); } }

        public Subjects(List<TeachingSubject> subjects)
        {
            _subjects = subjects;
        }

        public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.Name == subjectName)
                .AddExamGrade(regNumber, grade);
        }

        public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            _subjects.Find(d => d.Name == subjectName)
                .AddActivityGrade(regNumber, grade);
        }

        public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            _subjects.Find(d => d.Name == subjectName)
                .AddAttendance(regNumber, attendance);
        }

        public void SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            _subjects.Find(d => d.Name == subjectName).SetActivityProportion(proportion);
        }
    }
}
