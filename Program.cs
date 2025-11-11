using System;
using Loop;

class Program
{
    static void Main()
    {
       /* Operators op = new Operators();

        
        int a = 15;
        int b = 20;
        int number = 13;

        
        op.Add(a, b);
        op.Subtract(a, b);
        op.Multiply(a, b);
        op.Divide(a, b);
        op.OddEvenFinder(number);
        
        NullOperations nullOps = new NullOperations();
        nullOps.PerformNullChecks(); 
       Loop.IfElse check = new Loop.IfElse();
       check.Checkage(); */
       Console.WriteLine("Enter a number (1-7) to get the day of the week:");
       int dayNumber = Convert.ToInt32(Console.ReadLine());

       SevenDay day = new SevenDay();
       day.PrintDay(dayNumber);
    }
}