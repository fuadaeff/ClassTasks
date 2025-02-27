namespace studentClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telebenin adini daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Telebenin yasini daxil edin:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Telebenin ortalamasini daxil edin:");
            int gpa = int.Parse(Console.ReadLine());

            Student student1 = new Student(name, age, gpa);
            student1.GetStudentInfo(gpa);
        }
        public class Student
        {
            public string Name;
            public int Age;
            public int GPA;
            public Student(string name, int age, int gpa) {
                Name = name;
                Age = age;
                GPA = gpa;
            }
            public void GetStudentInfo(int gpa) {
                if (gpa > 90)
                {
                    Console.WriteLine($"{Name},{Age},{GPA} - ELACI!");
                }
                else if(gpa < 51)
                {
                    Console.WriteLine($"{Name},{Age},{GPA} - KESILIB!");
                }
            }
        }
    }
}
