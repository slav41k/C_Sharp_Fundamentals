using System;

class Program
{
    static void Main()
    {
        
        //Task 1
        
        Console.Write("Enter 2 numbers [a;b]:\na = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numbers from {a} to {b} which divided by 3 without remainder:");
        for (int i = Math.Min(a, b); i <= Math.Max(a, b); i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
        
        
        //Task 2
        
        Console.WriteLine("Enter some text and receive each second character:");
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i += 2)
            Console.Write(text[i]);
        Console.WriteLine();
        
        
        //Task 3
        
        Console.Write("Enter the name of the drink (coffee, tea, juice, water):");
        string input = Console.ReadLine();
        switch (input.ToLower())
        {
            case "tea" :
                Console.WriteLine($"{30:C}");
                break;
            case    "water" :
                Console.WriteLine($"{20:C}");
                break;
            case "coffee" :
            case "juice" :
                Console.WriteLine($"{45:C}");
                break;
            default:
                Console.WriteLine("We don't have such drinks, sorry bro");
                break;
        }
        
        
        //Task 4
        
        Console.WriteLine("Enter count of numbers: ");
        int count = Int32.Parse(Console.ReadLine());
        int[] nums = new int [count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter {i + 1} number: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        double average = 0;
        for (int i = 0; i < nums.Length; i++)
            sum += (nums[i] >= 0) ? nums[i] : 0;
        if (nums[count - 1] < 0)
        {
             average = sum / (nums.Length - 1);
        }
        else
        {
            average = nums.Average();
        }
        Console.WriteLine($"Sum: {sum}\nAvarage: {average}");
        
        
        //Task 5
        
        Console.Write("Enter random year: ");
        int year = Int32.Parse(Console.ReadLine());
        Console.WriteLine((year % 4 == 0) ? $"{year} is leap" : $"{year} is not leap year");
        
        
        //Task 6
        
        Console.Write("Enter random number : ");
        int num = Int32.Parse(Console.ReadLine());
        int sumOfNum = 0;
        while (num != 0)
        {
            sumOfNum += (num % 10);
            num /= 10;
        }
        Console.WriteLine($"Sum of digits =  {sumOfNum}");
        
        
        //Task 7
        
        Console.Write("Enter number: ");
        int number = Int32.Parse(Console.ReadLine());
        bool isAllDigitsOdd = true;
        while (number != 0)
        {
            if (number % 2 == 0)
            {
                isAllDigitsOdd = false;
                break;
            }
            else
                isAllDigitsOdd = true;

            number /= 10;
        }
        Console.WriteLine(isAllDigitsOdd ? "Number contains only odd digits" : "Number contains even digits");
        
    }
    
}
