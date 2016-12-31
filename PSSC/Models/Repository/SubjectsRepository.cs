using Models.Common.Professor;
using Models.Common.Subject;
using Models.Contexts.Professor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repository
{
    // Repository for Subjects aggregat root
    public class SubjectsRepository : IRepository<Contexts.Professor.Subjects>
    {
        private static List<Contexts.Professor.Subjects> _subjects = new List<Contexts.Professor.Subjects>();
        private static Contexts.Professor.Subjects subjects = new Contexts.Professor.Subjects(_subjects);

        public IEnumerable<Contexts.Professor.Subjects> List
        {
            get
            {
                yield return subjects;
            }
        }

        public void Add(Contexts.Professor.Subjects entity)
        {
            var result = subjects.AllSubjects.FirstOrDefault(s => s.Equals(entity));

            if (result != null) throw new DuplicateWaitObjectException();

            _subjects.Add(entity);
            Console.WriteLine("New subject was added.");
        }

        public void Delete(Contexts.Professor.Subjects entity)
        {
            var result = subjects.AllSubjects.FirstOrDefault(s => s.Equals(entity));

            if (result == null) throw new MissingMemberException();

            _subjects.Remove(entity);
            Console.WriteLine("A subject was deleted.");
        }

        public void Update(Contexts.Professor.Subjects entity)
        {
            throw new NotImplementedException();
        }

        public Contexts.Professor.Subjects FindById(Guid Id)
        {
            var result = _subjects.Find(s => s.GetId == Id);
            Console.WriteLine("A subject with given id - " + Id + " was found.");

            return result;
        }
    }
}
