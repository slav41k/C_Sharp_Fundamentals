namespace HW6;

public class Number
{
    private List<int> numbers = new List<int>();
    public void Input(out int num1, out int num2)
    {
        input:
        try
        {
            Console.WriteLine("Enter 2 numbers: \nFirst number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Second number: ");
            num2 = Int32.Parse(Console.ReadLine());

            if (num2 == 0)
                throw new DivideByZeroException("Cannot divide by zero");

            if (num1 < Int32.MinValue || num1 > Int32.MaxValue || num2 < Int32.MinValue || num2 > Int32.MaxValue)
                throw new OverflowException(" Value was either too large or too small");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            goto input;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            goto input;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
            goto input;
        }
        
    }
    public double Div(int num1, int num2)
    {
        double result = ((double)num1 / num2);
        return result;
    }

    public void ReadNumber(int start, int end, List<int> numbers)
    {
        inputList:
        try
        {
            Console.WriteLine("Enter start number: ");
            start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number: ");
            end = Int32.Parse(Console.ReadLine());

            if (Math.Abs(start - end) < 10)
            {
                throw new ArgumentException("Difference of 2 numbers should be more than 10");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            goto inputList;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        for (int i = 0; i < 10; i++)
        {
            inputNumbers:
            try
            {
                Console.WriteLine($"Enter {i + 1} number:");
                int number = Int32.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new ArgumentException($"Number should be from {start} to {end}");
                }

                if (numbers[i] > numbers[i + 1])
                {
                    throw new Exception("Numbers should be from largest to smallest");
                }

                numbers.Add(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto inputNumbers;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                goto inputNumbers;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto inputNumbers;
            }
        }
    }

    public override string ToString()
    {
        return $"{numbers}";
    }
}