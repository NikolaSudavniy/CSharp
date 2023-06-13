using System;
using System.Collections.Generic;

namespace StudentBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Student student1 = new Student();
            student1.InputInfo("Alex", "Kurapov", "Igorevich", "BPU-1821", 29);
            int[] programmingScores1 = { 7, 11, 9, 8, 12, 10 };
            int[] administrationScores1 = { 9, 11, 7, 8, 12, 10 };
            int[] designScores1 = { 7, 10, 9, 9, 9, 12 };
            student1.SetScore(0, programmingScores1);
            student1.SetScore(1, administrationScores1);
            student1.SetScore(2, designScores1);
            students.Add(student1);

            Student student2 = new Student();
            student2.InputInfo("Denis", "Makarenko", "Andreyewich", "BPU-1821", 27);
            int[] programmingScores2 = { 2, 2, 2, 2, 2, 2 };
            int[] administrationScores2 = { 3, 3, 3, 3, 3, 3 };
            int[] designScores2 = { 7, 4, 5, 4, 7 };
            student2.SetScore(0, programmingScores2);
            student2.SetScore(1, administrationScores2);
            student2.SetScore(2, designScores2);
            students.Add(student2);

            Student student3 = new Student();
            student3.InputInfo("Anna", "Ilchenko", "Antonovna", "BPU-1821", 27);
            int[] programmingScores3 = { 9, 9, 11, 10, 9, 10 };
            int[] administrationScores3 = { 7, 8, 7, 9, 7, 7 };
            int[] designScores3 = { 7, 12, 12, 10, 7 };
            student3.SetScore(0, programmingScores3);
            student3.SetScore(1, administrationScores3);
            student3.SetScore(2, designScores3);
            students.Add(student3);

            foreach (Student student in students)
            {
                student.ShowInfo();
                Console.WriteLine("\nAverage score for Programming: {0}", student.GetAverageScore(0));
                Console.WriteLine("Average score for Administration: {0}", student.GetAverageScore(1));
                Console.WriteLine("Average score for Design: {0}", student.GetAverageScore(2));
                Console.WriteLine();
            }
        }
    }
}
