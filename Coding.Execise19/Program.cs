namespace Coding.Execise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSounds();
        }

        public class Animal
        {
            // TODO: Declare a virtual method MakeSound
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal sound");
            }
        }

        public class Dog : Animal
        {
            // TODO: Override the MakeSound method
            public override void MakeSound()
            {
                base.MakeSound();
                Console.WriteLine("Dog barks");
            }
        }
        public static void PrintSounds()
        {
            // TODO: Create an instance of Dog and call the MakeSound method
            Dog dog1 = new Dog();
            dog1.MakeSound();
        }
        
    }
}
