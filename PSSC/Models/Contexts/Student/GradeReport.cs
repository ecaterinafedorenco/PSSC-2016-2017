using Models.Common.Subject;
using Models.Generics;
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
        private HashSet<EnrolledSubject> _gradeReport { get; set; }

        public GradeReport(HashSet<EnrolledSubject> gradeReport)
        {
            _gradeReport = gradeReport;
        }

        public SubjectSituation GetSubjectSituation(PlainText subjectName)
        {
            return null;
        }
    }
}