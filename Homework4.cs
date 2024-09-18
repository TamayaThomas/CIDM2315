namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Console.WriteLine("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        int largest = Question1(num1,num2);
        Console.WriteLine($"a ={num1}; b={num2}");
        Console.WriteLine($"The largest number is: {largest}");
        // Call Q2_method()
        Console.WriteLine("Enter an integer number: ");
        string input_num = Console.ReadLine();
        int N = Convert.ToInt32(input_num);
        Console.WriteLine("Enter left or right: ");
        string input_shape = Console.ReadLine();
        Console.WriteLine ($"N is {N}; shape is {input_shape}");
        Question2(N, input_shape);
    }
        // Q1_method
            static int Question1(int a, int b){
                if(a>b){
                    return a;
                }
                else{
                   return b;
                }
            }
        //Q2_method
        static void Question2(int N, string shape){
            if(shape=="left"){
                for(int row = 1; row<=N; row++){
                     for(int col = 1; col<=N; col++){
                if(row>=col)
                    Console.Write('*');
                 }
                    Console.WriteLine("");
                }
            }
            if(shape == "right"){
                 for (int row = 1; row <= N; row++){
                    for (int space = 1; space <= N - row; space++){
                        Console.Write(" "); 
                        }
                    for (int col = 1; col <= row; col++){
                        Console.Write("*"); 
                        }
                         Console.WriteLine(); // Move to the next line after each row
                }
            }
        }
    }