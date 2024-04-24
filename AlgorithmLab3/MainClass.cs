using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLab3
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            ListReferenceBased<Person> myList = new ListReferenceBased<Person>();
            //Print out that is has nothing in it
            Console.WriteLine($"Listan inngehåller nu: {myList.Lenght()} noder.");

            //Add people to the list:
            myList.Add(new Person("Benny", 100, "Bagare"));
            myList.Add(new Person("Sören", 101, "Snickare"));
            myList.Add(new Person("Maria", 102, "Maskinist"));
            myList.Add(new Person("Roger", 103, "Universitetsadjunkt - Informatik"));

            // Printing the list
            myList.Display();

            //Check if it's empty:
            Console.WriteLine($"\nisEmpty? - {myList.isEmpty()}");
            //Show that the list has 4 nodes
            Console.WriteLine($"Listan inngehåller nu: {myList.Lenght()} noder.");
            //Add a person at index 1
            Console.WriteLine("Lägger till en person!");
            myList.InsertAt(new Person("Alma", 104, "Advokat"), 1);
            myList.Display();

            //Remove the first person
            Console.WriteLine("Tar bort en person!");
            myList.RemoveAt(0);
            myList.Display();

            //Finding a person at specific index:
            Console.WriteLine($"Person på index 2 är: {myList.GetValueAt(1)}");

            //Clearing list
            myList.Clear();
            Console.WriteLine($"\nListan har tömts - Kontrollerar: isEmpty? - {myList.isEmpty()}");
            Console.WriteLine($"Listan inngehåller nu: {myList.Lenght()} noder.");

            //try and get a person on an invalid index
            try
            {
                Console.WriteLine("Provar att söka ut Person på index 10:");
                Console.WriteLine($"{myList.GetValueAt(10)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }









        }
    }
}
