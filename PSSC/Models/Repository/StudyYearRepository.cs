using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using Models.Common.Subject;

namespace Models.Repository
{
    // Repository for StudyYear aggregat root
    public class StudyYearRepository : IRepository<StudyYear>
    {
        public IEnumerable<StudyYear> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(StudyYear entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(StudyYear entity)
        {
            throw new NotImplementedException();
        }

        public StudyYear FindById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Save(Subjects aggregate)
        {
            throw new NotImplementedException();
        }

        public void Update(StudyYear entity)
        {
            throw new NotImplementedException();
        }
    }
}
