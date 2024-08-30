namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
       // Given values
        double X = 2.5;
        double Y = 3.3;

        // Liner Equation
        double Z = (4 * (X * X) + 3 * Y);

        Console.WriteLine($"X = {X}, Y = {Y}");

        // The result of the equation
        Console.WriteLine("The value of Z is: " + Z);
    }
}
