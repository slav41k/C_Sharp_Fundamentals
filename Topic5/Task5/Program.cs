using System;
using System.Formats.Asn1;

namespace Task5
{
internal class Program
    {
        static void Main(string[] args)
        {
            List<IFlayable> birdsAndPLanes = new List<IFlayable>();

            bool continueAdding = true;

            while (continueAdding)
            {
                a1:
                Console.WriteLine("What u wanna to add? (bird/plane/exit)");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "exit")
                {
                    continueAdding = false;
                }
                else if (choice.ToLower() == "bird")
                {
                    Bird bird = new Bird();
                    bird.Input();
                    birdsAndPLanes.Add(bird);
                }
                else if (choice.ToLower() == "plane")
                {
                    Plane plane = new Plane();
                    plane.Input();
                    birdsAndPLanes.Add(plane);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    goto a1;
                }

                if (continueAdding == false)
                {
                    foreach (var flayable in birdsAndPLanes)
                    {
                        flayable.Fly();
                    }
                }
            }
        }
    }
}