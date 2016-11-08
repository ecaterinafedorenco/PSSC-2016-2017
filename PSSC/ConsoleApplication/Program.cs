using Models.Factory;
using Models.Generics;
using Models.Professor;
using Models.Repository;
using Models.Student;
using Models.Subject;
using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class Program
    {
        private static SubjectInformation subjectInformation;
        private static Dictionary<Student, SubjectSituation> signedUpStudentsGrades;
        private static List<Grade> list;

        static void Main(string[] args)
        {
            var subjectsRepository = new SubjectsRepository();
            signedUpStudentsGrades = new Dictionary<Student, SubjectSituation>();
            list = new List<Grade>();
            list.Add(new Grade(4));
            list.Add(new Grade(5));
            
            subjectInformation = new SubjectInformation(new PlainText("PSSC"), new Credits(4), EvaluationType.Distributed, Proportion.OneThird,
                new Models.Professor.Professor(Guid.NewGuid(), new PlainText("Iercan D")));
            var subject = new Subject(subjectInformation);
            var _subject = SubjectsFactory.Instance.CreateInstance(subjectInformation);   

            subjectsRepository.Add(_subject);

            Console.WriteLine(_subject);

            subjectsRepository.Delete(_subject);

            Console.WriteLine("\n\nPress any key to terminate.");
            Console.ReadLine();
        }
    }
}
