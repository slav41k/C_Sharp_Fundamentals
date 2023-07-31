using System;

namespace task1
{
    class Program
    {
        static void Main()
        {
            //task1
            
            int a, b;
            Console.Write("Enter a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b = ");
            b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            double quotient = (double) (a) / b;
            Console.WriteLine($"a + b = {sum}");
            Console.WriteLine($"a - b = {difference}");
            Console.WriteLine($"a * b = {product}");
            Console.WriteLine($"a / b = {quotient}");
            
            //task2
            
            Console.WriteLine("How are you?");
            string mood = Console.ReadLine();
            Console.WriteLine($"You are {mood}");
            
            //task3

            char ex1, ex2, ex3;
            Console.Write("Enter 1st symbol: ");
            ex1 = Char.Parse(Console.ReadLine());
            Console.Write("Enter 2nd symbol: ");
            ex2 = Char.Parse(Console.ReadLine());
            Console.Write("Enter 3rd symbol: ");
            ex3 = Char.Parse(Console.ReadLine());
            Console.WriteLine($"You enter {ex1}, {ex2}, {ex3}");
            
            //task4
            
            int n, k;
            Console.Write($"Enter n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter k = ");
            k = Convert.ToInt32(Console.ReadLine());
            bool positive = n > 0 && k > 0;
            if (positive == true)
                Console.WriteLine($"{n} and {k} are both positive");
            else
                Console.WriteLine("Numbers are not both positive");


        }
    }
}