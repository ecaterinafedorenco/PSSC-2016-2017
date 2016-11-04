using Models.Factory;
using Models.Generics;
using Models.Professor;
using Models.Repository;
using Models.Student;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.EntityFramework.ContextDb;

namespace ConsoleApplication
{
    class Program
    {
        private static Professor professor;
        private static PlainText nameSubject;
        private static Credits credits;
        private static SubjectInformation subjectInformation;
        private static Proportion proportion;
        private static PlainText nameProfessor;
        //private static ProfessorRepository professorRepository = new ProfessorRepository();

        static void Main(string[] args)
        {
            var repository = new SubjectRepository();
            Guid id = new Guid();
            nameSubject = new PlainText("pssc");
            credits = new Credits(4);
            proportion = new Proportion(1, 2);
            nameProfessor = new PlainText("Iercan D");
            professor = new Models.Professor.Professor(id, nameProfessor);

            subjectInformation = new SubjectInformation(nameSubject, credits, EvaluationType.Distributed, proportion, professor);
            
            //professorRepository.Add(professor);
            var subject = SubjectsFactory.Instance.createInstance(subjectInformation);
            
            repository.Add(subject);

            //subject.SignUpStudent(SubjectsFactory.Instance.createStudnet("8642", "Ecaterina Fedorenco"));

            Console.Write(repository.List.Count());
            Console.WriteLine("\n\nline\n");

            // FOR ENTITY FRAMEWORK
            //Context c = new Context();
            //c.Subjects.Add(subject);
            //c.SaveChanges();
            
            //var result = from r in c.Subjects select r;
            //foreach (var r in result)
            //{
            //    Console.WriteLine(r.SubjectInfo.Name);
            //}

            //Console.ReadKey(true);


            repository.Delete(subject);
            Console.WriteLine(repository.List.Count());
            Console.WriteLine("\nline2\n");
            Console.WriteLine("\n\nPress any key to terminate.");
            Console.ReadLine();
        }
    }
}
