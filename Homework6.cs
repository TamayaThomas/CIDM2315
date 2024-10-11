namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor P1 = new Professor();
        P1.profName = "Alice";
        P1.classTeach = "Java";
        P1.SetSalary(9000);

        Professor P2 = new Professor();
        P2.profName = "Bob";
        P2.classTeach = "Math";
        P2.SetSalary(8000);

        Student S1 = new Student();
        S1.studentName = "Lisa";
        S1.classEnroll = "Java";
        S1.SetGrade(90);

        Student S2 = new Student();
        S2.studentName = "Tom";
        S2.classEnroll = "Math";
        S2.SetGrade(80);
        
        Console.WriteLine($"Professor {P1.profName} teaches {P1.classTeach}, and the salary is: {P1.GetSalary()}");
        Console.WriteLine($"Professor {P2.profName} teaches {P2.classTeach}, and the salary is: {P2.GetSalary()}");

        Console.WriteLine($"Student {S1.studentName} enrolls {S1.classEnroll}, and the grade is: {S1.GetGrade()}");
        Console.WriteLine($"Student {S2.studentName} enrolls {S2.classEnroll}, and the grade is: {S2.GetGrade()}");

        double salaryDifference = P1.GetSalary() - P2.GetSalary();
        Console.WriteLine($"The salary difference between {P1.profName} and {P2.profName} is: {salaryDifference}");
        double totalGrade = S1.GetGrade() + S2.GetGrade();
        Console.WriteLine($"The total grade of {S1.studentName} and {S2.studentName} is: {totalGrade}");
    }
}
class Professor 
{
    public string profName { get; set; }
    public string classTeach { get; set; }
    private double salary;
    public void SetSalary(double salaryAmount){
        salary = salaryAmount;
    }

    public double GetSalary(){
        return salary;
    }
}
class Student
{
    public string studentName { get; set; }
    public string classEnroll { get; set; }
    private double studentGrade;

    public void SetGrade(double newGrade){
            studentGrade = newGrade;
    }
    public double GetGrade(){
            return studentGrade;
    }
}