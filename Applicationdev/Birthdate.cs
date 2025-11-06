namespace Applicationdev;

public class Birthdate
{
    public DateTime DateOfBirth { get; set; }

    public Birthdate(int year, int month, int day)
    {
        DateOfBirth = new DateTime(year, month, day);
    }

    // Method to calculate age in years
    public int GetAge()
    {
        DateTime now = DateTime.Now;
        int age = now.Year - DateOfBirth.Year;

        
        if (now < DateOfBirth.AddYears(age))
        {
            age--;
        }

        return age;
    }

    
    public DateTime AddTenDays()
    {
        return DateOfBirth.AddDays(10);
    }
}