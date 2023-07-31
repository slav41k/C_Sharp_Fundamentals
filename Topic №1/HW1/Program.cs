using System;
namespace HW1
{
    class Program
    {
        static void Main()
        {
            //task1
            Console.Write("Enter square side: ");
            int a = Int32.Parse(Console.ReadLine());
            double s = Math.Pow(a, 2);
            int p = a * 4;
            Console.WriteLine($"Area: {s} \nPerimeter: {p}");
            
           //task2 
             
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you {name}?");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you are {age} years old");
            
            //task3
            
            Console.Write("Enter radius:");
            double r = Double.Parse(Console.ReadLine());
            double length = 2 * Math.PI * r;
            double area = Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.Write($"Length: {length:F2} \nArea: {area:F2} \nVolume: {volume:F2}");

        }
    }
}