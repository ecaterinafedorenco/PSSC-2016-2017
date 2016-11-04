using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Student;

namespace Models.Repository
{
    public class StudentRepository : IRepository<Student.Student>
    {
        private static List<Models.Student.Student> _students = new List<Student.Student>();

        public IEnumerable<Student.Student> List
        {
            get
            {
                return _students;
            }
        }

        public void Add(Student.Student entity)
        {
            var result = _students.FirstOrDefault(s => s.Equals(entity));

            if (result != null) throw new DuplicateWaitObjectException();

            _students.Add(entity);
            Console.WriteLine("New student was added.");
        }

        public void Delete(Student.Student entity)
        {
            var result = _students.FirstOrDefault(s => s.Equals(entity));

            if (result == null) throw new MissingMemberException();

            _students.Remove(entity);
            Console.WriteLine("A student was deleted.");
        }

        public Student.Student FindById(Guid Id)
        {
            var result = _students.Find(s => s.GetId == Id);
            Console.WriteLine("A student with given id - " + Id + " was found.");

            return result;
        }

        public void Update(Student.Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
