namespace Task5;

public class Plane : IFlayable
{
    private string _mark;
    private int _highFly;

    public Plane() { }
    
    public void Input()
    {
        Console.WriteLine("Enter a mark of the Plane:");
        _mark = Console.ReadLine();
        Console.WriteLine($"How high {_mark} can fly?");
        _highFly = Int32.Parse(Console.ReadLine());
    }

    public void Fly()
    {
        Console.WriteLine($"Mark: {_mark}, Max height:  {_highFly:N} meters");
    }
}