namespace StaffRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1: What classes needs to be included in the program?
            //Adding 3 classes for each inout needed. Getting the wront output "System.Action", and not user input.

            //Assignment 2: Which attributes and methods should be included in these classes?

            //Assignment 3: Write the program

            Console.WriteLine("Welcome to the Staff Register");

            displayFirstName();
            displayLastName();
            displaySalary();

            Console.WriteLine("Hello " + displayFirstName + " " + displayLastName + " " + "your salary is " + displaySalary + ".");
        }

        static void displayFirstName() 
        {
            Console.WriteLine("Insert your first name: ");
            string firstName = Console.ReadLine();
        }

        static void displayLastName()
        {
            Console.WriteLine("Insert your last name: ");
            string lastName = Console.ReadLine();
        }

        static void displaySalary()
        {
            Console.WriteLine("Insert your salary: ");
            string salary = Console.ReadLine();

            int res = Convert.ToInt32(salary);
        }
    }
}