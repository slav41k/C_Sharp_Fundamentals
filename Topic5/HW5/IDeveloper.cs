namespace HW5;

public interface IDeveloper

{
    string Tool { get; set; }
    int Age { get; set; }

    void Create();
    void Destroy(string tool);
}