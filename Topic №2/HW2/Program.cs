using System;

//Task3

/*enum HTTPError
{
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402,
    Forbidden = 403,
    NotFound = 404,
    MethodNotAllowed = 405
}*/

//Task4

struct Dog
{
    public string Name;
    public string Mark;
    public int Age;
    public override string ToString()
    {
        return $"Name: {Name}, Mark: {Mark}, Age: {Age}";
    }
}

//Task1
class Program
{
    static void Main()
    {
        Console.Write("Enter 3 numbers and check if they are all in the range [-5.5]:\nFirst number =  ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Second number =  ");
        float secondNumber = float.Parse(Console.ReadLine());
        Console.Write("Third number =  ");
        float thirdNumber = float.Parse(Console.ReadLine());
        bool allInRange = firstNumber >= -5 && firstNumber <= 5 &&
                          secondNumber >= -5 && secondNumber <= 5 &&
                          thirdNumber >= -5 && thirdNumber <= 5;
        string check = allInRange ? "All numbers are in range" : "Not all numbers are in range";
        Console.WriteLine(check);

//Task2

        Console.Write("Enter integer numbers and output min and mfx of them:\nFirst number = ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Second number =  ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Third number =  ");
        int number3 = int.Parse(Console.ReadLine());
        int maxNumber = (number1 > number2)
            ? ((number1 > number3) ? number1 : number3)
            : ((number2 > number3) ? number2 : number3);

        int minNumber = (number1 < number2)
            ? ((number1 < number3) ? number1 : number3)
            : ((number2 < number3) ? number2 : number3);
        Console.WriteLine($"Minimum number: {minNumber},\nMaximum number: {maxNumber}");

//Task3

/*Console.WriteLine("Enter HTTP Error: ");
int httpError = Int32.Parse(Console.ReadLine());
HTTPError errorCode = HTTPError.httpError;*/

//Task4

        Dog myDog;

        Console.Write("Enter dog's name: ");
        myDog.Name = Console.ReadLine();

        Console.Write("Enter dog's mark: ");
        myDog.Mark = Console.ReadLine();

        Console.Write("Enter dog's age: ");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
        {
            Console.Write("Invalid input. Please enter a valid age: ");
        }

        myDog.Age = age;

        Console.WriteLine("Information about the dog:");
        Console.WriteLine(myDog.ToString());
    }
}