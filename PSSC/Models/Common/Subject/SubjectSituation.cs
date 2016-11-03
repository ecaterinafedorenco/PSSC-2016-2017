using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Subject
{
    public abstract class SubjectSituation
    {
        protected Attendance _attendance { get; set; }
        protected List<Grade> _examGrades { get; set; }
        protected List<Grade> _activityGrades { get; set; }

        public SubjectSituation()
        {

        }

        public SubjectSituation(Attendance attendance, List<Grade> examGrades, List<Grade> activityGrade)
        {
            _attendance = attendance;
            _examGrades = examGrades;
            _activityGrades = activityGrade;
        }

        public Grade GetActivityAverage()
        {
            Grade average;

            average = new Grade(_activityGrades.Aggregate(0.0m, (acc, curr) => acc + curr.Value) / _activityGrades.Count);

            return average;
        }

        public Grade GetExamAverage()
        {
            Grade average;
            
            average = new Grade(_examGrades.Aggregate(0.0m, (acc, curr) => acc + curr.Value) / _examGrades.Count);

            return average;
        }
    }
}
