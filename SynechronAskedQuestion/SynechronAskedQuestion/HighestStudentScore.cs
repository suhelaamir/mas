using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    class HighestStudentScore
    {
        public static void HighestScore()

        {

            ArrayList arrList = new ArrayList();

            arrList.Add(
                new Student
                {
                    FirstName = "Svetlana",
                    LastName = "Omelchenko",
                    Scores = new int[] { 98, 92, 81, 100 }
                });

            arrList.Add(
                new Student
                {
                    FirstName = "Claire",
                    LastName = "O’Donnell",
                    Scores = new int[] { 75, 84, 91, 39 }
                });

            arrList.Add(
                new Student
                {
                    FirstName = "Sven",
                    LastName = "Mortensen",
                    Scores = new int[] { 88, 94, 65, 91 }
                });

            arrList.Add(
                new Student
                {
                    FirstName = "Cesar",
                    LastName = "Garcia",
                    Scores = new int[] { 97, 89, 85, 82 }
                });
            Console.WriteLine("===============Find Highest Score==================");
            var highestScore = (from Student s in arrList where s.Scores[0]>98
                                select s).Take(2).FirstOrDefault();

            if (highestScore != null)
            {
                Console.WriteLine("Highest score in the list is: " + highestScore.Scores[0]);
            }

            // Keep the console window open in debug mode. 
            Console.WriteLine("Press any key to exit.");
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Scores { get; set; }
    }
}
