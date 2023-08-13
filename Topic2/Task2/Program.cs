//Task 1

Console.Write("Enter 2 integers and check if they can be day and month:\nday = ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("month = ");
int month = Convert.ToInt32(Console.ReadLine());

bool isValidDay = (day > 0) && (day <= 31);
bool isValidMonth = (month > 0) && (month <= 12);

string answer = isValidDay && isValidMonth ? "Day and month can be" :
                isValidDay ? "Day can be, month cannot" :
                isValidMonth ? "Month can be, day cannot" :
                              "Day and month cannot be";
Console.WriteLine(answer);

//Task 2

Console.Write("Enter double number: ");
double number = Convert.ToDouble(Console.ReadLine());
int firstNumber = (int)((number - (int)number) * 10);
int secondNumber = (int)(((number - (int)number) * 10 - firstNumber) * 10);
int sum = secondNumber + firstNumber;
Console.WriteLine(sum);

//Task 3

Console.Write("Enter the time of day (hour): ");
int h = Convert.ToInt32(Console.ReadLine());
bool isItMorning = (h >= 6) && (h <= 11);
bool isItAfternoon = (h > 11) && (h < 19);
bool isItEvening = (h >= 19) && (h <= 23);
bool isItNight = (h >= 0) && (h < 6);
string greetings = isItMorning ? "Good morning!" :
                   isItAfternoon ? "Good afternoon!" :
                   isItEvening ? "Good evening!" :
                   isItNight ? "Good night!" :
                   "Incorrect time";
Console.WriteLine(greetings);

//Task




