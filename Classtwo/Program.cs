// See https://aka.ms/new-console-template for more information

using Classtwo;

public class Program
{
    
    public static void Main()
    {
       /* Console.WriteLine("Enter your age: ");
        string ageInput = Console.ReadLine();       
        int age = Convert.ToInt32(ageInput);        
        int futureAge = age + 5;                     
        Console.WriteLine($"In 5 years, you will be {futureAge} years old."); */
       
       /* double price = 250.0;
       int quantity = 5;

       double total = price * quantity;
       double discountedTotal = total > 1000 ? total * 0.9 : total; 

       Console.WriteLine($"Total: {total}, Discounted Total: {discountedTotal}"); */
       
       /* string sentence = "C# is Powerful and Fun!";
       string lower = sentence.ToLower();
       string upper = sentence.ToUpper();
       int length = sentence.Length;

       Console.WriteLine($"Original: {sentence}");
       Console.WriteLine($"Uppercase: {upper}");
       Console.WriteLine($"Lowercase: {lower}");
       Console.WriteLine($"Length: {length}"); */
       
       /*Guid orderId = Guid.NewGuid();
       DateTime orderDate = DateTime.Now;
       TimeSpan deliveryTime = TimeSpan.FromHours(48);
       DateTime expectedDelivery = orderDate.Add(deliveryTime);

       Console.WriteLine($"Order ID: {orderId}");
       Console.WriteLine($"Order Date: {orderDate}");
       Console.WriteLine($"Expected Delivery Date: {expectedDelivery}"); */
       
       /* Book book1 = new Book();
       book1.Title = "The Power of Habit";
       book1.Author = "Charles Duhigg";
       book1.Price = 500;

       
       Book book2 = book1;
       book2.Price = 600; 
       Console.WriteLine("Book 1 Details:");
       Console.WriteLine($"Title: {book1.Title}, Author: {book1.Author}, Price: {book1.Price}");

       Console.WriteLine("\nBook 2 Details:");
       Console.WriteLine($"Title: {book2.Title}, Author: {book2.Author}, Price: {book2.Price}");

       Console.WriteLine("\n=> Changing book2.Price also changed book1.Price because both share the same memory reference."); */
      
      /* double? temperature = null;

      if (temperature == null)
          Console.WriteLine("Temperature not recorded");
      else
          Console.WriteLine($"Temperature: {temperature}°C");

      
      temperature = 36.6;

      if (temperature == null)
          Console.WriteLine("Temperature not recorded");
      else
          Console.WriteLine($"Temperature: {temperature}°C"); */
      List<string> products = new List<string>();
      
      products.Add("Laptop");
      products.Add("Mouse");
      products.Add("Keyboard");
      products.Remove("Mouse"); 
      
      Console.WriteLine("Product List:");
      foreach (var product in products)
      {
          Console.WriteLine($"- {product}");
      }
      
      
      Dictionary<string, int> stock = new Dictionary<string, int>();
      
      stock["Laptop"] = 10;
      stock["Keyboard"] = 15;
      stock["Monitor"] = 5;
      
      Console.WriteLine("\nProduct Stock Details:");
      foreach (var item in stock)
      {
          Console.WriteLine($"{item.Key} - Quantity: {item.Value}");
      }
      
    }
}   
    
    
