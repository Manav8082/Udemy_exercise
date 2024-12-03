namespace Coding.Exercise12
{
    public class Program
        {
            public static void Main(string[] args)
            {
                // TODO
                Person person1 = new Person("John", 30);
                person1.Greet();
            }
        }

        public class Person
        {
            private int _age;
            private string _name;
            // TODO
            public Person(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string Name
            {
                get
                {
                    return _name;
                }
                set
                {
                    _name = value;
                }
            }
            public int Age
            {
                get
                {
                    return _age;
                }
                set
                {
                    if (value > 0)
                    {
                        _age = value;
                    }
                }
            }
            public void Greet()
            {
                Console.WriteLine("Hello, my name is {0} and I am {1} years old.", _name, _age);
            }

        }
}
