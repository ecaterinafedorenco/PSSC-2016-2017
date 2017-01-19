<<<<<<< HEAD
﻿using Models.Contexts.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Common.Subject;
=======
﻿using System;
using System.Collections.Generic;
using Models.Student;
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c

namespace Models.Repository
{
    // Repository for GradeReport aggregat root
<<<<<<< HEAD
    class GradeReportRepository : IRepository<GradeReport>
=======
    class GradeReportRepository : IRepository<Student.GradeReport>
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
    {
        public IEnumerable<GradeReport> List
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(GradeReport entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(GradeReport entity)
        {
            throw new NotImplementedException();
        }

        public GradeReport FindById(Guid Id)
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
        public void Update(GradeReport entity)
        {
            throw new NotImplementedException();
        }
    }
}
