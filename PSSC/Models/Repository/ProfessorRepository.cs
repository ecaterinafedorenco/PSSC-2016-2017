using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Professor;

namespace Models.Repository
{
    public class ProfessorRepository : IRepository<Professor.Professor>
    {
        private static List<Models.Professor.Professor> _professors = new List<Professor.Professor>();

        public ProfessorRepository()
        {

        }

        public IEnumerable<Professor.Professor> List
        {
            get
            {
                return _professors;
            }
        }

        public void Add(Professor.Professor entity)
        {
            var result = _professors.FirstOrDefault(p => p.Equals(entity));

            if (result != null) throw new DuplicateWaitObjectException();

            _professors.Add(entity);
            Console.WriteLine("New professor was added.");
        }

        public void Delete(Professor.Professor entity)
        {
            var result = _professors.FirstOrDefault(p => p.Equals(entity));

            if (result == null) throw new MissingMemberException();

            _professors.Remove(entity);
            Console.WriteLine("A professor was deleted.");
        }

        public Professor.Professor FindById(Guid Id)
        {
            var result = _professors.Find(p => p.GetId == Id);
            Console.WriteLine("A professor with given id - " + Id + " was found.");

            return result;
        }

        public void Update(Professor.Professor entity)
        {
            _professors.Where(p => p.Equals(entity))
                .Select(S => { S.Name = new Generics.PlainText("Update Value"); return S; }).ToList();
        }
    }
}
