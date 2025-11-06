namespace workshop;

public class Typecasting
{
    private byte byteVar;
    private short shortVar;
    private int intVar;
    private long longVar;
    private float floatVar;
    private double doubleVar;
    private decimal decimalVar;
    private char charVar;
    private bool boolVar;

    public Typecasting(byte var, short shortVar, int intVar, long longVar, float floatVar, double doubleVar,
        decimal decimalVar, char charVar, bool boolVar)
    {
        this.byteVar = var;
        this.shortVar = shortVar;
        this.intVar = intVar;
        this.longVar = longVar;
        this.floatVar = floatVar;
        this.doubleVar = doubleVar;
        this.decimalVar = decimalVar;
        this.charVar = charVar;
        this.boolVar = boolVar;
    }

    public void PrintVariables()
    {
        Console.WriteLine("=== Variable Types and Values (From Object) ===");
        Console.WriteLine($"byte: {byteVar}");
        Console.WriteLine($"short: {shortVar}");
        Console.WriteLine($"int: {intVar}");
        Console.WriteLine($"long: {longVar}");
        Console.WriteLine($"float: {floatVar}");
        Console.WriteLine($"double: {doubleVar}");
        Console.WriteLine($"decimal: {decimalVar}");
        Console.WriteLine($"char: {charVar}");
        Console.WriteLine($"bool: {boolVar}");
    }



    public static void Run()
    {
        byte b = 10;
        short s = 200;
        int i = 3000;
        long l = 40000L;
        float f = 12.5f;
        double d = 99.99;
        decimal dec = 123.456m;
        char c = 'A';
        bool flag = true;
        
        Typecasting obj = new Typecasting(b, s, i, l, f, d, dec, c, flag);
        
        int number = 42;
        string numberString = number.ToString();

        string piString = "3.14";
        double piValue = Convert.ToDouble(piString);
        
        obj.PrintVariables();
        Console.WriteLine($"Converted int → string: {numberString}");
        Console.WriteLine($"Converted string → double: {piValue}");
    }
}