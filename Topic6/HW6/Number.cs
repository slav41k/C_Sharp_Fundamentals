namespace HW6;

public static class Number
{
    public static double Div(int lNum, int rNum) => ((double)lNum / rNum);

    public static void Input(out int fstNum, out int sndNum)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter 2 numbers. \nFirst number: ");
                fstNum = Int32.Parse(Console.ReadLine() ?? throw new NullReferenceException($"{nameof(fstNum)} is null"));

                Console.WriteLine("Second number: ");
                sndNum = Int32.Parse(Console.ReadLine() ?? throw new NullReferenceException($"{nameof(sndNum)} is null"));

                if (sndNum == 0)
                    throw new DivideByZeroException("Cannot divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            break;
        }
    }

    public static void ReadNumber(List<int> numbers)
    {
        while (true)
        {
            int start,
                end;
            try
            {
                Console.WriteLine("Enter start number: ");
                start = Int32.Parse(Console.ReadLine() ?? throw new NullReferenceException($"{nameof(start)} is null"));
                Console.WriteLine("Enter end number: ");
                end = Int32.Parse(Console.ReadLine() ?? throw new NullReferenceException($"{nameof(end)} is null"));

                if (Math.Abs(start - end) < 10)
                    throw new ArgumentException("Difference of 2 numbers should be more than 10");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }

            int previousNumber = -1;
            for (int ii = 0; ii < 10; ii++)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine($"Enter {ii + 1} number:");
                        int number = Int32.Parse(Console.ReadLine() ?? throw new NullReferenceException($"{nameof(number)} is null"));

                        if (number < start || number > end)
                            throw new ArgumentException($"Number should be from {start} to {end}");
                        if (previousNumber != -1 && previousNumber >= number)
                            throw new Exception("Numbers should be from smallest to largest");
                        if (end - number < 10 - (ii + 1))
                            throw new Exception("You won't rich end with this number");
                        previousNumber = number;
                        numbers.Add(number);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        continue;
                    }

                    break;
                }
            }

            break;
        }
    }

    public static void OutPut(List<int> numbers)
    {
        for (int j = 0; j < numbers.Count; j++)
        {
            Console.WriteLine($"Number {j + 1}: {numbers[j]}");
        }
    }

}
