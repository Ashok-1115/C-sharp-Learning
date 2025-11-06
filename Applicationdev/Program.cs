
using Applicationdev;

//UserName userobj = new UserName(name: "Ashok", luckyNumber: 7);
//userobj.Print();

/*static void main(string[] args)
{
    Circle c1 = new Circle( 5);
    c1.CalculateArea();
    c1.CalculatePerimeter();
    c1.Display();
}
using System;

namespace Applicationdev
{
    Typecasting.Run();
   

} */

using System;

class Program
{
    static void Main()
    {
        // Create a Birthdate object (example date - you can change it)
        Birthdate myBirthday = new Birthdate(2003, 5, 15);

        DateTime currentDate = DateTime.Now;
        int age = myBirthday.GetAge();
        DateTime newDate = myBirthday.AddTenDays();

        Console.WriteLine($"Your Birthday: {myBirthday.DateOfBirth.ToShortDateString()}");
        Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
        Console.WriteLine($"Your Age: {age} years");
        Console.WriteLine($"10 days after your birthday: {newDate.ToShortDateString()}");
    }
}


//GenericCollection.cs();



