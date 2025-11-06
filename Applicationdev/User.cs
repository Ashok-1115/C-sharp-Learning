namespace Applicationdev;

public class UserName
{
    private string name;
    private int luckyNumber;

    public UserName(string name, int luckyNumber)
    {
        this.name = name;
        this.luckyNumber = luckyNumber;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {this.name}, LuckyNumber: {this.luckyNumber}");
    }
}