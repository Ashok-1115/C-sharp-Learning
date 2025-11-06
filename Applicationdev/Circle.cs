namespace Applicationdev;

public partial class Circle
{
   private const double Pi = 3.14;
   private double radius;
   private double area;
   private double perimeter;

   public Circle(double radius)
   {
      this.radius = radius;
   }

   public void CalculateArea()
   {
      area = Pi * radius * radius;
   }

   public void CalculatePerimeter()
   {
      perimeter = 2 * Pi * radius;
   }

   public void Display()
   {
      Console.WriteLine($"Radius: {radius}");
      Console.WriteLine($"Area: {area}");
      Console.WriteLine($"Perimeter: {perimeter}");
   }
}