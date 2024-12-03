namespace Coding.Exercise11
{
    public class MyClass
    {
        // TODO: Declare a private readonly field to store the value
        private readonly string prop;
        // TODO: Create a public read-only property to expose the field's value
        public string getValue()
        {
            return prop;
        }

        public MyClass(string value)
        {
            // TODO: Initialize the readonly field with the value parameter
            prop = value;
        }
    }

    public class Exercise
    {
        public static void Main(string[] args)
        {
            // TODO: Create an instance of MyClass with the value "Read-Only Property Value"
            MyClass myclass = new MyClass("Read-Only Property Value");
            // TODO: Print the value of the read-only property to the console
            Console.WriteLine(myclass.getValue());
        }
    }
}
