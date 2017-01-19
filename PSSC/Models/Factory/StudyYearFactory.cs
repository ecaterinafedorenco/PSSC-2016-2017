using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Factory
{
    // Creates a StudyYearFactory instance
    public class StudyYearFactory
    {
        public static readonly StudyYearFactory Instance = new StudyYearFactory();

        private StudyYearFactory()
        { }

        // Creates a StudyYear instance
        public Deanship.StudyYear CreateInstance(Deanship.StudyYear studyYear)
        {
            return studyYear;
        }
    }
}
