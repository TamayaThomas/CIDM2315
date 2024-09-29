namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
           // Call Q1_method()
            Console.WriteLine("Please enter two numbers for: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int largest = Question1(num1, num2);
            Console.WriteLine($"a = {num1}; b = {num2}");
            Console.WriteLine($"The largest number is: {largest}");

            // Call Q2_method()
            Console.WriteLine("Please enter four numbers for: ");
            int num3 = Convert.ToInt32(Console.ReadLine()); int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine()); int num6 = Convert.ToInt32(Console.ReadLine());
            int largest2 = Question2(num3, num4, num5, num6);
            Console.WriteLine($"a = {num3}; b = {num4}; c = {num5}; d = {num6}");
            Console.WriteLine($"The largest number is: {largest2}");
            // Call Q3_method1()
            Console.WriteLine("Please input birth year: ");
            int birth_year = Convert.ToInt32(Console.ReadLine());

            bool isAdult = checkAge(birth_year);
            if (isAdult)
            {
                Console.WriteLine("You are 18 or older.");
            }
            else{
                Console.WriteLine("You are younger than 18.");
            }
            //Call Q3_method2()
            createAccount();


    }
         // Q1_method
        static int Question1(int a, int b)
        {
            return (a > b) ? a : b;
        }
        //Q2_method     
        static int Question2(int a, int b, int c, int d)
        {
            int largestAB = Question1(a, b);  
            int largestABC = Question1(largestAB, c); 
            int largestABCD = Question1(largestABC, d);  

            return largestABCD; 
        }
        //Q3_method1
        static bool checkAge(int birth_year){
            int current_year = DateTime.Now.Year; 
            int age = current_year - birth_year;

            return age >= 18; 
         }
         //Q3_method2
         static void createAccount(){
            Console.WriteLine("Input Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Input Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Input Password Again: ");
            string password2 = Console.ReadLine();
            Console.WriteLine("Input birthyear: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());      

             bool isAdult = checkAge(birthYear);

                if (isAdult){
                    if (password == password2){
                        Console.WriteLine("Account is created successfully.");
                        }
                        else{
                        Console.WriteLine("Wrong password.");
                        }
                    }
                    else{
                    Console.WriteLine("Could not create an account");
                    }

            
         }
}