namespace Coding.Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.WriteLine("Enter the first number:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string s1 = Console.ReadLine();
            num1 = int.Parse(s);
            num2 = int.Parse(s1);
            Console.WriteLine("Choose an operation: +, -, *, /");
            char operation;
            operation = Console.ReadLine()[0];
            if (num2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else
            {
                switch (operation)
                {
                    case '+':
                        {
                            Console.WriteLine("Result: " + (num1 + num2));
                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine("Result: " + (num1 - num2));
                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine("Result: " + (num1 * num2));
                            break;
                        }
                    case '/':
                        {
                            Console.WriteLine("Result: " + (num1 / num2));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                            break;
                        }
                }

            }
        }
    }
}
