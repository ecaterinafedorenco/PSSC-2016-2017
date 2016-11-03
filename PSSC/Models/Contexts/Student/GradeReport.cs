using Models.Common.Subject;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Student
{
    //Aggregate Root
    public class GradeReport
    {
        public RegistrationNumber Id { get; internal set; }
        private HashSet<EnrolledSubject> _gradeReport { get; set; }

        public GradeReport(RegistrationNumber id, HashSet<EnrolledSubject> gradeReport)
        {
            Id = id;
            _gradeReport = gradeReport;
        }

        public ViewableSituation GetSubjectSituation(PlainText subjectName)
        {
            ViewableSituation situation;

            situation = _gradeReport.First(d => d.Name == subjectName).Situation;

            return situation;
        }
    }
}