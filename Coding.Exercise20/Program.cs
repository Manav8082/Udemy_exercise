namespace Coding.Exercise20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMessages();
        }
        public class Person
        {
            // TODO: Declare a constructor that takes a name and prints a message
            public Person(string name)
            {
                Console.WriteLine($"Person constructor: {name}");
            }
        }

        public class Employee : Person
        {
            // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
            public Employee(string name, int Id) : base(name)
            {
                Console.WriteLine($"Employee constructor: {name}, ID: {Id}");
            }
        }

        public static void PrintMessages()
        {
            // TODO: Create an instance of Employee and print the messages
            Employee emp = new Employee("John Doe", 123);
        }
    }
}
