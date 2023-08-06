namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name and birthday(Month/Day/Year) of a person:");
            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Person {i+ 1}:");
                people[i] = new Person();
                people[i].Input();
            }
            Console.WriteLine("\nInformation about people:\n");
            foreach (Person person in people)
            {
                person.Output();
            }

            for (int i = 0; i < people.Length; i++)
                people[i].ChangeName();
            Console.WriteLine("\n\nChanged names:\n");
            
            foreach (Person person in people)
            {
                person.Output();
            }
            
            Console.WriteLine("\n\nPeople with the same name:\n");

            for (int j = 0; j < people.Length - 1; j++)
            {
                for (int i = j + 1; i < people.Length; i++)
                {
                    if (people[j] == people[i])
                    {
                        Console.WriteLine($"{people[j].Name} and {people[i].Name} names are equals\n");
                    }
                }
            }
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.ReadKey();

        }
    }
}