namespace Coding.Exercise23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessPayments();
        }

        
        public static void ProcessPayments()
        {
            // TODO: Create instances of CreditCardPayment and PayPalPayment, and call the ProcessPayment method on each
            CreditCardPayment cardPayment = new CreditCardPayment();
            cardPayment.ProcessPayment();
            PayPalPayment paypalPayment = new PayPalPayment();
            paypalPayment.ProcessPayment();
        }
    
    }
    public interface IPayment
    {
        // TODO: Declare a method ProcessPayment
        public void ProcessPayment();
    }

    public class CreditCardPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    public class PayPalPayment : IPayment
    {
        // TODO: Implement the ProcessPayment method
        public void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }
}
