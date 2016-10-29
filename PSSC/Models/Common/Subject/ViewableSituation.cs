using Models.Generics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Subject
{
    public class ViewableSituation : SubjectSituation
    {
        public int Attendance { get { return _attendance.Count; } }
        public ReadOnlyCollection<Grade> ExamGrades { get { return _examGrades.AsReadOnly(); } }
        public ReadOnlyCollection<Grade> ActivityGrades { get { return _activityGrades.AsReadOnly(); } }

        public ViewableSituation()
        {

        }

        public ViewableSituation(Attendance att, List<Grade> examGrades, List<Grade> activityGrades) 
            : base(att, examGrades, activityGrades)
        {

        }
    }
}
