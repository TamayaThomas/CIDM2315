namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.WriteLine("Input an integer: ");
        int primeNumber = Convert.ToInt32(Console.ReadLine());
        bool Prime = true;
            if (primeNumber <= 1)
            {
                Prime = false;
            }
            else
            {
                for (int i = 2; i <= primeNumber / 2; i++)
                {
                    if (primeNumber % i == 0)
                    {
                        Prime = false;
                        break;
                    }
                }
            }

            if (Prime)
            {
                Console.WriteLine($"N is prime.");
            }
            else
            {
                Console.WriteLine($"N is non-prime.");
            }
            Console.WriteLine();


        // Code for Q2
        Console.WriteLine("Please assign an int value to N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        for(int row = 1; row<= N; row++){
            for(int col = 1; col<= N; col++)
            {
                Console.Write('*');
            }
            Console.WriteLine("");
        } 
        // Code for Q3
        Console.WriteLine("Please assign an int value to N: ");
        int J = Convert.ToInt32(Console.ReadLine());
        for(int row = 1; row<=J; row++){
            for(int col = 1; col<=J; col++)
            {
                if(row>=col)
                    Console.Write('*');
            }
            Console.WriteLine("");
        }
    }
}
