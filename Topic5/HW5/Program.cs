using System.Collections;
using System.Collections.Generic;
namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter information about programmers:");
            Programmer[] programmers = new Programmer[2];
            for (int i = 0; i < programmers.Length; i++)
            {
                Console.WriteLine($"Programmer {i + 1}:");
                programmers[i] = new Programmer();
                programmers[i].Create();
            }

            Console.WriteLine("\nInformation about programmers:\n");
            foreach (Programmer programmer in programmers)
            {
                Console.WriteLine(programmer.ToString());
            }
            
            
            
            
            Console.WriteLine("Enter information about builders:"); 
            Builder[] builders = new Builder[2];
            for (int i = 0; i < builders.Length; i++)
            {
                Console.WriteLine($"Builder {i + 1}:");
                builders[i] = new Builder();
                builders[i].Create();
            }

            Console.WriteLine("\nInformation about builders:\n");
            foreach (Builder builder in builders)
            {
                Console.WriteLine(builder.ToString());
            }
            
            
            
            
            Console.WriteLine("Enter the language which u want to destroy: ");
            string languageToDestroy = Console.ReadLine();
            for (int i = 0; i < programmers.Length; i++)
            {
                programmers[i].Destroy(languageToDestroy);
            }
            
            Console.WriteLine("\nInformation about programmers:\n");
            foreach (Programmer programmer in programmers)
            {
                Console.WriteLine(programmer.ToString());
            }

            Console.WriteLine("Enter the tool which u want to destroy: ");
            string toolToDestroy = Console.ReadLine();
            for (int i = 0; i < builders.Length; i++)
            {
                builders[i].Destroy(toolToDestroy);
            }

            Array.Sort(programmers, Comparer<Programmer>.Default);
            Array.Sort(builders, Comparer<Builder>.Default);


            
            Console.WriteLine("\nInformation about programmers:\n");
            foreach (Programmer programmer in programmers)
            {
                Console.WriteLine(programmer.ToString());
            }
            
            
            Console.WriteLine("\nInformation about builders:\n");
            foreach (Builder builder in builders)
            {
                Console.WriteLine(builder.ToString());
            }




        }
    }
}