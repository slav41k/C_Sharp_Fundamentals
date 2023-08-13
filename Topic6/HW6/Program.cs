using System;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number number = new();
            // int number1, number2;
            // number.Input(out number1, out number2);
            // double result = number.Div(number1, number2);
            // Console.WriteLine($"Result of dividing: {result:N3}");
            // int start, end;
            List<int> numbers = new();
            Number number = new();
            
            number.ReadNumber(0, 0, numbers);
            
        }
    }
}