namespace Loop;


public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;
        
        string ternaryCheck = (username == null) ? "Username is not available" : username;
        Console.WriteLine("Ternary Operator Check: " + ternaryCheck);
        
        string nullCoalescingCheck = username ?? "Username is not available";
        Console.WriteLine("Null-Coalescing Operator Check: " + nullCoalescingCheck);
        
        username ??= "DefaultUser";
        Console.WriteLine("After Null-Coalescing Assignment: " + username);
    }
}

