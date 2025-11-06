namespace Applicationdev;

public class GenericCollection
{
namespace workshop;

public class GenericCollections
{
    public static void Run()
    {
        Console.WriteLine("=== Task 5: Generic Collections (List and Dictionary) ===\n");
        
        // List
        // Create and initialize a List<string> with 3 fruits
        List<string> fruits = new List<string> { "Apple", "Banana", "Mango" };

        // Add a new fruit
        fruits.Add("Orange");

        // Remove one fruit
        fruits.Remove("Banana");

        // Display remaining fruits
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"- {fruit}");
        }

        // DICTIONARY 

        // Create and initialize a Dictionary<int, string>
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            {1, "Apple"},
            {2, "Mango"},
            {3, "Orange"}
        };

        // Add a new fruit (ID + Name)
        fruitDictionary.Add(4, "Grapes");

        // Display all key-value pairs
        Console.WriteLine("Fruits in the dictionary:");
        foreach (KeyValuePair<int, string> kvp in fruitDictionary)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}
}