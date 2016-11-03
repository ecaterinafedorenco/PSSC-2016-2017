using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common.Subject;
using Models.Generics.ValueObjects;
using Models.Generics;
using System.Diagnostics.Contracts;

namespace Models.Contexts.Professor
{
    //Aggregate Root
    public class Subjects : Entity<Guid>
    {
        private HashSet<TeachingSubject> _subjects { get; set; }
        public ReadOnlyCollection<TeachingSubject> AllSubjects { get { return _subjects.ToList().AsReadOnly(); } }

        private Subjects(Guid id) : base(id)
        {
            Contract.Requires<ArgumentException>(id != null, "Guid is null!");
        }

        private Subjects() : base(Guid.NewGuid())
        {

        }

        public Subjects(HashSet<TeachingSubject> subjects) : this()
        {
            Contract.Requires(subjects != null, "Teaching subject list is null!");

            _subjects = subjects;
        }

        public Subjects(Guid id, HashSet<TeachingSubject> subjects) : this(id)
        {
            Contract.Requires(subjects != null, "Teaching subject list is null!");

            _subjects = subjects;
        }

        public void AddExamGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            Contract.Requires(subjectName != null, "Subject name is null!");
            Contract.Requires(regNumber != null, "Registration number is null!");
            Contract.Requires(grade != null, "Grade is null!");

            _subjects.First(d => d.Name == subjectName)
                .AddExamGrade(regNumber, grade);
        }

        public void AddActivityGrade(PlainText subjectName, RegistrationNumber regNumber, Grade grade)
        {
            Contract.Requires(subjectName != null, "Subject name is null!");
            Contract.Requires(regNumber != null, "Registration number is null!");
            Contract.Requires(grade != null, "Grade is null!");

            _subjects.First(d => d.Name == subjectName)
                .AddActivityGrade(regNumber, grade);
        }

        public void AddAttendance(PlainText subjectName, RegistrationNumber regNumber, Attendance attendance)
        {
            Contract.Requires(subjectName != null, "Subject name is null!");
            Contract.Requires(regNumber != null, "Registration number is null!");
            Contract.Requires(attendance != null, "Attendance is null!");

            _subjects.First(d => d.Name == subjectName)
                .AddAttendance(regNumber, attendance);
        }

        public void SetActivityProportion(PlainText subjectName, Proportion proportion)
        {
            Contract.Requires(subjectName != null, "Subject name is null!");
            Contract.Requires(proportion != null, "Proportion is null!");

            _subjects.First(d => d.Name == subjectName).SetActivityProportion(proportion);
        }
    }
}
