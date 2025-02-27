namespace personClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Fuad", 18);
            person1.Print();
        }
        public class Person
        {
            public string Name;
            public int Age;
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void Print()
            {
                Console.WriteLine($"Ad: {Name}, Yaş: {Age}");
            }
        }
    }
}
