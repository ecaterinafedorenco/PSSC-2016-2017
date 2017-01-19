using Models.Generics;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Models.Student
{
    //Aggregate Root
    public class GradeReport
    {
        private Guid _gradeReportId;
        private ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> _gradeReport;

        public GradeReport(Guid gradeReportId, ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> gradeReport)
        {
            _gradeReportId = gradeReportId;
            _gradeReport = gradeReport;
        }

        public SubjectSituation GetSubjectSituation(PlainText subjectName)
        {
            return _gradeReport.First(d => d.Key.Name == subjectName).Value;
        }
    }
}