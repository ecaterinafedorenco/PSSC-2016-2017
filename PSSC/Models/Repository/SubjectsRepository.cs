<<<<<<< HEAD
﻿using Models.Common.Professor;
using Models.Common.Subject;
using Models.Contexts.Professor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c

namespace Models.Repository
{
    // Repository for Subjects aggregat root
<<<<<<< HEAD
    public class SubjectsRepository : IRepository<Contexts.Professor.Subjects>
    {
        private static List<Contexts.Professor.Subjects> _subjects = new List<Contexts.Professor.Subjects>();
        private static Contexts.Professor.Subjects subjects;// = new Contexts.Professor.Subjects(_subjects);

        public IEnumerable<Contexts.Professor.Subjects> List
        {
            get
            {
                yield return subjects;
            }
        }

        public void Add(Contexts.Professor.Subjects entity)
=======
    public class SubjectsRepository : IRepository<Subject.Subject>
    {
        private static List<Models.Subject.Subject> _subjects = new List<Models.Subject.Subject>();
        private static Professor.Subjects subjects = new Professor.Subjects(_subjects);

        public SubjectsRepository() { }

        public IEnumerable<Subject.Subject> List
        {
            get
            {
                return subjects.AllSubjects;
            }
        }

        public void Add(Subject.Subject entity)
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
        {
            var result = subjects.AllSubjects.FirstOrDefault(s => s.Equals(entity));

            if (result != null) throw new DuplicateWaitObjectException();

            _subjects.Add(entity);
            Console.WriteLine("New subject was added.");
        }

<<<<<<< HEAD
        public void Delete(Contexts.Professor.Subjects entity)
=======
        public void Delete(Subject.Subject entity)
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
        {
            var result = subjects.AllSubjects.FirstOrDefault(s => s.Equals(entity));

            if (result == null) throw new MissingMemberException();

            _subjects.Remove(entity);
            Console.WriteLine("A subject was deleted.");
        }

<<<<<<< HEAD
        public void Update(Contexts.Professor.Subjects entity)
        {
            throw new NotImplementedException();
        }

        public Contexts.Professor.Subjects FindById(Guid Id)
=======
        public Subject.Subject FindById(Guid Id)
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
        {
            var result = _subjects.Find(s => s.GetId == Id);
            Console.WriteLine("A subject with given id - " + Id + " was found.");

            return result;
        }

<<<<<<< HEAD
        public void Save(Common.Subject.Subjects aggregate)
=======
        public void Update(Subject.Subject entity)
>>>>>>> 78fd45ae9705b12e934894956018ead12d28df4c
        {
            throw new NotImplementedException();
        }
    }
}
