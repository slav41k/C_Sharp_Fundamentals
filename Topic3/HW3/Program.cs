namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Task 1
            
            Console.Write("Enter text: ");
            string str = Console.ReadLine();
            int count = 0;
            foreach (char symbol in str)
            {
                if (symbol == 'a' || symbol == 'o' || symbol == 'e' || symbol == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine($"The counts of characters ‘a’, ’o’, ’i’, ’e’  in this text : {count}");

            
            //Task 2
            Console.Write("Enter the number of month: ");
            int month = Int32.Parse(Console.ReadLine());
            int daysInMonth = DateTime.DaysInMonth(2024, month);
            Console.WriteLine((daysInMonth == 29) ? $"The month have 28 or 29 days" : $"The month have {daysInMonth} days");
            
            
            //Task 3

            int[] numbers = new int[10];
            bool firstFiveNumbersArePositive = true;
            int sum = 0;
            int product = 1;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Your numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}; ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] <= 0)
                {
                    firstFiveNumbersArePositive = false;
                    break;
                }
            }

            if (firstFiveNumbersArePositive)
            {
                for (int i = 0; i < numbers.Length / 2; i++)
                {
                    sum += numbers[i];
                }
            }
            else
            {
                for (int i = numbers.Length / 2; i < numbers.Length; i++)
                {
                    product *= numbers[i];
                }
            }

            Console.WriteLine((firstFiveNumbersArePositive)
                ? $"Sum of first 5 positive numbers: {sum}"
                : $"Product of last 5 numbers: {product}");

        }
    }
}
