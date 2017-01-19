using Models.Generics;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Diagnostics.Contracts;

namespace Models.Subject
{
    //Entity
    public class Subject
    {
        public static decimal proportion;
        public Guid GetId { get; internal set; }
        public SubjectInformation SubjectInfo { get; internal set; }

        private Dictionary<Student.Student, SubjectSituation> _signedUpStudentsGrades;
        public Dictionary<Student.Student, SubjectSituation> SignedUpStudentsGrades { get { return _signedUpStudentsGrades; } }

        public Subject()
        {
            _signedUpStudentsGrades = new Dictionary<Student.Student, SubjectSituation>();
        }

        public Subject(Guid getId, Dictionary<Student.Student, SubjectSituation> signedUpStudentsGrades, SubjectInformation subjectInfo)
        {
            GetId = getId;
            _signedUpStudentsGrades = signedUpStudentsGrades;
            SubjectInfo = subjectInfo;
        }

        public Subject(SubjectInformation subjectInfo) : this()
        {
            SubjectInfo = subjectInfo;
        }

        public void SignUpStudent(Student.Student student)
        {
            Contract.Requires(student != null, "Student cannot be null!");
            _signedUpStudentsGrades.Add(student, new SubjectSituation());
        }

        public Grade GetAverageForStudent(RegistrationNumber regNumber)
        {
            Contract.Requires(regNumber != null, "regNumber");
            SubjectSituation situation = _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;

            decimal activityGrade = situation.ActivityGrade.Value;
            decimal examAverage = situation.GetExamAverage(SubjectInfo.Evaluation);

            if (SubjectInfo.ActivityProportion == Proportion.OneHalf)
            {
                proportion = 0.5M;
            }
            else if (SubjectInfo.ActivityProportion == Proportion.OneThird)
            {
                proportion = 0.3M;
            }

            return new Grade(activityGrade * proportion + (1 - proportion) * examAverage);
        }

        public SubjectSituation GetSituationForStudent(RegistrationNumber regNumber)
        {
            return _signedUpStudentsGrades.First(d => d.Key.RegNumber == regNumber).Value;
        }

        public override string ToString()
        {
            return "\nSubject: " + SubjectInfo.Name.Text + ", \n" + SubjectInfo.Credits.Count.ToString() + ", \n" +
                SubjectInfo.Evaluation.ToString() + ", \n" + SubjectInfo.ActivityProportion.ToString() +
                 "; \n\nProfessor: " + SubjectInfo.Professor.Name.Text + ", \n" + SubjectInfo.Professor.GetId.ToString() + "\n";
        }
    }
}
