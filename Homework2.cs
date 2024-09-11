namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
       // Code for Q1
        Console.WriteLine("Enter a letter grade (A, B, C, D, F):");
        string grade = Console.ReadLine().ToUpper();

        switch (grade)
        {
            case "A":
                Console.WriteLine("\nGPA points: 4");
                break;
            case "B":
                Console.WriteLine("\nGPA points: 3");
                break;
            case "C":
                Console.WriteLine("\nGPA points: 2");
                break;
            case "D":
                Console.WriteLine("\nGPA points: 1");
                break;
            case "F":
                Console.WriteLine("\nGPA points: 0");
                break;
            default:
                Console.WriteLine("\nWrong Letter Grade!");
                break;
        }

    
        // Code for Q2
        {
            Console.WriteLine("Please input the first num: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please input the second num: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the third num: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Find the smallest number
            double smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }

            if (num3 < smallest)
            {
                smallest = num3;
            }
            Console.WriteLine("The smallest value is: " + smallest);


    }
    
    // Code for Bonus question
    {
        Console.WriteLine("Please input a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        if (isLeapYear)
        {
            Console.WriteLine(year + "is a leap year");
        }
        else
        {
            Console.WriteLine(year + "is not a leap year");
        }

    }
}
}
