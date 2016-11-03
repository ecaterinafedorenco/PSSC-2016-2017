using Models.Generics.ValueObjects;
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
        public Attendance Attendance { get { return _attendance; } }
        public ReadOnlyCollection<Grade> ExamGrades { get { return _examGrades.AsReadOnly(); } }
        public ReadOnlyCollection<Grade> ActivityGrades { get { return _activityGrades.AsReadOnly(); } }

        public ViewableSituation(RegistrationNumber regNumber) : base(regNumber)
        {

        }

        public ViewableSituation(RegistrationNumber regNumber, Attendance att, List<Grade> examGrades, List<Grade> activityGrades) 
            : base(regNumber, att, examGrades, activityGrades)
        {

        }
    }
}
