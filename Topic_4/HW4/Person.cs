namespace HW4;

public class Person
{
    private string _name;
    private DateTime _birthYear;

    public string Name
    {
        set { _name = value; }
        get { return _name; }
    }

    public DateTime BirthYear
    {
        set { _birthYear = value; }
        get { return _birthYear; }
    }
    
    public Person() {}

    public Person(string name, DateTime birthYear)
    {
        this._name = name;
        this._birthYear = birthYear;
    }

    public void Input()
    {
        Console.Write("Enter the name: ");
        _name = Console.ReadLine();

        Console.Write("Enter the birthday: ");
        _birthYear = DateTime.Parse(Console.ReadLine());
    }
    
    public int GetAge()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - _birthYear.Year;
        if (_birthYear.DayOfYear > currentDate.DayOfYear)
        {
            age--;
        }

        return age;
    }
    public void Output()
    {
        Console.WriteLine($"Name: {Name}\nBirth year: {BirthYear.Year}\nAge: {GetAge()}");
    }

    public string ChangeName()
    {
        if (GetAge() < 16)
            _name = "Very young";
        return _name;
    }
    
    public static bool operator ==(Person first, Person second)
    {
        return (first._name==second._name);
    }

    public static bool operator !=( Person first, Person second)
    {
        return !(first._name == second._name);
    }
    
    public override string ToString()
    {
        return $"Name: {Name}\nBirth year: {BirthYear.Year}\nAge: {GetAge()}";
    }
}