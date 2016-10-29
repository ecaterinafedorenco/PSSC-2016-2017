using Models.Common.Subject;
using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Professor
{
    public class TeachingSubject : Subject
    {
        private Dictionary<Common.Student.Student, GradeableSituation> _enrolledStudents { get; set; }

        public Proportion ActivityProportion { get; internal set; }

        public TeachingSubject(Dictionary<Common.Student.Student, GradeableSituation> enrolledStudents, PlainText subjectName, Credits credits)
            : base(subjectName, credits)
        {
            _enrolledStudents = enrolledStudents;
        }

        public void AddExamGrade(RegistrationNumber regNumber, Grade grade)
        {
            _enrolledStudents.First(d => d.Key.RegNumber == regNumber)
                .Value.ExamGrades.Add(grade);
        }

        public void AddActivityGrade(RegistrationNumber regNumber, Grade grade)
        {
            _enrolledStudents.First(d => d.Key.RegNumber == regNumber)
                .Value.ActivityGrades.Add(grade);
        }

        public void AddAttendance(RegistrationNumber regNumber, Attendance attendance)
        {
            _enrolledStudents.First(d => d.Key.RegNumber == regNumber)
                .Value.Attendance = attendance;
        }

        public void ModifyExamGrade(RegistrationNumber regNumber, Grade grade)
        {
            //TODO
        }

        public void SetActivityProportion(Proportion proportion)
        {
            ActivityProportion = proportion;
        }
    }
}
