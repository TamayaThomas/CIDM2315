namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
       Customer c1 = new Customer(110, "Alice", 28);
       Customer c2 = new Customer(111, "Bob", 30);

       c1.PrintCusInfo();
       c2.PrintCusInfo();

       c1.ChangeID(220);
       c2.ChangeID(222);
       
       c1.PrintCusInfo();
       c2.PrintCusInfo();

        c1.CompareAge(c2);

    }
}
class Customer
{
    private int cus_id;
    public int getCus_id(){
        return cus_id;
    }
    public string cus_name {get;set;}
    public int cus_age {get; set;}
    public Customer(int cus_id, string cus_name, int cus_age){
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }
   public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }
    public void PrintCusInfo(){
        Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }
    public void CompareAge(Customer objCustomer){
        if(cus_age > objCustomer.cus_age){
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age < objCustomer.cus_age){
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else{
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are the same age.");
        }
    }
}