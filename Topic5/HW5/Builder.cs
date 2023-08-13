using System.Collections;
using System.Collections.Generic;


namespace HW5;

public class Builder : IDeveloper, IComparable<Builder>

{
    private string _tool;
    private string _name;
    private int _age;
    
    public int Age
    {
        get => _age;
        set => _age = value;
    }
    
    public string Tool
    {
        get => _tool;
        set => _tool = value;
    }
    
    public Builder(){}
    
    public void Create()
    {
        Console.Write("Enter the name of Builder: ");
        _name = Console.ReadLine();

        Console.Write("Enter the age of Builder: ");
        _age = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the tool of Builder: ");
        _tool = Console.ReadLine();
    }

    public void Destroy(string tool)
    {
        if (tool.ToLower() == _tool.ToLower())
            _tool = null;
    }
    
    public int CompareTo(Builder other)
    {
        return Age.CompareTo(other.Age);
    }


    public override string ToString() => String.Format($"Name : {_name}, Age: {_age}, Language: {_tool}");
}