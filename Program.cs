namespace StaffRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1: What classes needs to be included in the program?

            //Assignment 2: Which attributes and methods should be included in these classes?

            //Assignment 3: Write the program

            Console.WriteLine("Welcome to the Staff Register");
            Console.WriteLine("Insert your first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Insert your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Insert your salary: ");
            string salary = Console.ReadLine();

            int res;
            res = Convert.ToInt32(salary);

            Console.WriteLine("Hello " + firstName + " " + lastName + " " + "your salary is " + salary + ".");
            Console.ReadLine(); 
        }
    }
}