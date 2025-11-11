using System;

namespace Loop
{
    public class IfElse
    {
        public void Checkage()
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are a Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a Teenager");
            }
            else
            {
                Console.WriteLine("You are an Adult");
            }
        }
    }
}