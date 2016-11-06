using Models.Factory;
using Models.Generics;
using Models.Professor;
using Models.Repository;
using Models.Student;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        private static Professor professor;
        private static PlainText nameSubject;
        private static Credits credits;
        private static SubjectInformation subjectInformation;
        private static PlainText nameProfessor;
        private static Dictionary<Student, SubjectSituation> signedUpStudentsGrades;
        private static List<Grade> list;

        static void Main(string[] args)
        {
            var subjectsRepository = new SubjectsRepository();
            Guid id = new Guid();
            nameSubject = new PlainText("pssc");
            credits = new Credits(4);
            nameProfessor = new PlainText("Iercan D");
            professor = new Models.Professor.Professor(id, nameProfessor);
            signedUpStudentsGrades = new Dictionary<Student, SubjectSituation>();
            list = new List<Grade>();
            list.Add(new Grade(4));
            list.Add(new Grade(5));

            signedUpStudentsGrades.Add(new Student(Guid.NewGuid(), new RegistrationNumber("1234"), new PlainText("ecaterina"), new Credits(30)),
                new SubjectSituation(new Attendance(2), list, new Grade(8)));

            subjectInformation = new SubjectInformation(nameSubject, credits, EvaluationType.Distributed, Proportion.OneThird, professor);
            var subject = new Subject(subjectInformation);
            var _subject = SubjectsFactory.Instance.createInstance(subject);

            subjectsRepository.Add(_subject);
            subjectsRepository.Delete(_subject);

            Console.WriteLine("\n\nPress any key to terminate.");
            Console.ReadLine();
        }
    }
}
