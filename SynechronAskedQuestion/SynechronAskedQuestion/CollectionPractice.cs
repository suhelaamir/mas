using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynechronAskedQuestion
{
    public class CollectionPractice
    {
        public static void GetIndexInCollection()
        {
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Brachiosaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Compsognathus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            Console.WriteLine("\nIndexOf(\"Tyrannosaurus\"): {0}",
                    dinosaurs.IndexOf("Tyrannosaurus"));

            Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 3): {0}",
                dinosaurs.IndexOf("Tyrannosaurus", 3));

            Console.WriteLine("\nIndexOf(\"Tyrannosaurus\", 2, 2): {0}",
                dinosaurs.IndexOf("Tyrannosaurus", 2, 2));
        }
    }
}
