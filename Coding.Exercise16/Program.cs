namespace Coding.Exercise16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintStudents();
        }
        public static void PrintStudents()
        {
                // TODO
            Dictionary<string, Student> studentDict = new Dictionary<string, Student>();
            studentDict.Add("John", new Student(1, "John", 85));
            studentDict.Add("Alice", new Student(2, "Alice", 90));
            studentDict.Add("Bob", new Student(3, "Bob", 78));

            foreach (var i in studentDict)
            {
                Console.WriteLine("Name: {0}, Id: {1}, Grade: {2}", i.Key, i.Value._id, i.Value._grade);
            }
        }

        public class Student
        {
            public int _id { get; }
            public string _name { get; }
            public int _grade { get; }
            public Student(int id, string name, int grade)
            {
                _id = id;
                _name = name;
                _grade = grade;
            }
        }
    }
}
