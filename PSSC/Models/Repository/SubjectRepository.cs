using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Subject;

namespace Models.Repository
{
    public class SubjectRepository : IRepository<Subject.Subject>
    {
        private static List<Models.Subject.Subject> _subjects = new List<Models.Subject.Subject>();

        public SubjectRepository()
        {

        }

        public IEnumerable<Subject.Subject> List
        {
            get
            {
                return _subjects;
            }
        }

        public void Add(Subject.Subject entity)
        {
            var result = _subjects.FirstOrDefault(s => s.Equals(entity));

            if (result != null) throw new DuplicateWaitObjectException();

            _subjects.Add(entity);
            Console.WriteLine("New subject was added.");
        }

        public void Delete(Subject.Subject entity)
        {
            var result = _subjects.FirstOrDefault(s => s.Equals(entity));

            if (result == null) throw new MissingMemberException();

            _subjects.Remove(entity);
            Console.WriteLine("A subject was deleted.");
        }

        public Subject.Subject FindById(Guid Id)
        {
            var result = _subjects.Find(s => s.GetId == Id);
            Console.WriteLine("A subject with given id - " + Id + " was found.");

            return result;
        }

        public void Update(Subject.Subject entity)
        {
            throw new NotImplementedException();
        }
    }
}
