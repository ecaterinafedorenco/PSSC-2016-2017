<<<<<<< HEAD
﻿using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using Models.Common.Subject;
=======
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Deanship;
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c

namespace Models.Repository
{
    // Repository for StudyYear aggregat root
<<<<<<< HEAD
    public class StudyYearRepository : IRepository<StudyYear>
=======
    public class StudyYearRepository : IRepository<Deanship.StudyYear>
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
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

<<<<<<< HEAD
        public void Save(Subjects aggregate)
        {
            throw new NotImplementedException();
        }

=======
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
        public void Update(StudyYear entity)
        {
            throw new NotImplementedException();
        }
    }
}
