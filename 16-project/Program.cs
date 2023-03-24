using System.Xml.Linq;

namespace _16_project
{
    // requirements
    // open requirements file in the same folder
    // to make constructor => highlight vlaues you want in the class and press ctrl+.
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1000, "Ali A. ", 180, 10);

            Console.WriteLine(manager);

            Console.ReadKey();
        }
    }

    // press ctrl+. to move class to new file with its own name
}