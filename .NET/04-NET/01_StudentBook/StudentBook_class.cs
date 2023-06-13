using System;

namespace StudentBook
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private string group;
        private int age;
        private int[][] scores;

        public void InputInfo(string firstName, string lastName, string middleName, string group, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.middleName = middleName;
            this.group = group;
            this.age = age;
        }

        public int[] GetScores(int subjectIndex)
        {
            if (scores != null && subjectIndex >= 0 && subjectIndex < scores.Length)
            {
                return scores[subjectIndex];
            }

            return null;
        }

        public void SetScore(int subjectIndex, int[] subjectScores)
        {
            if (scores == null)
            {
                scores = new int[subjectScores.Length][];
            }

            scores[subjectIndex] = subjectScores;
        }

        public double GetAverageScore(int subjectIndex)
        {
            int[] subjectScores = GetScores(subjectIndex);
            if (subjectScores != null && subjectScores.Length > 0)
            {
                int sum = 0;
                foreach (int grade in subjectScores)
                {
                    sum += grade;
                }

                return (double)sum / subjectScores.Length;
            }

            return 0;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student info: \n");
            Console.WriteLine("Name: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Group: {0}", group);
            Console.WriteLine("Age: {0} \n", age);

            if (scores != null)
            {
                Console.WriteLine("Scores:");

                for (int i = 0; i < scores.Length; i++)
                {
                    int[] subjectGrades = scores[i];
                    if (subjectGrades != null)
                    {
                        Console.Write("Subject {0}: ", i + 1);
                        foreach (int grade in subjectGrades)
                        {
                            Console.Write("{0} ", grade);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
