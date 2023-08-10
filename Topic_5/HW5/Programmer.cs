namespace HW5;

public class Programmer : IDeveloper, IComparable<Programmer>

{
    private string _language;
    private string _name;
    private int _age;

    public int Age
    {
        get => _age;
        set => _age = value;
    }
    public string Tool
    {
        get => _language;
        set => _language = value;
    }
    public Programmer() { }
    
    public void Create()
    {
        Console.Write("Enter the name of Programmer: ");
        _name = Console.ReadLine();

        Console.Write("Enter the age of Programmer: ");
        _age = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the language of Programmer: ");
        _language = Console.ReadLine();
    }

    public void Destroy(string language)
    {
        if (language.ToLower() == _language.ToLower())
            _language = null;
    }

    public int CompareTo(Programmer other)
    {
        return Age.CompareTo(other.Age);
    }

    public override string ToString() => String.Format($"Name : {_name}, Age: {_age}, Language: {_language}");
}