namespace workersClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Fuad",1800,"IT");
            worker1.GetWorkerInfo("Fuad",1800,"IT");
            worker1.IncreaseSalary(1800);
        }
        public class Worker
        {
            public string Name; 
            public int Salary;
            public string Position;
            public Worker(string name, int salary, string position) {
                Name = name;
                Salary = salary;
                Position = position;
            }
            public void IncreaseSalary(int Salary) {
                Salary = Salary + 200;
                Console.WriteLine($"Iscinin yeni maasi: {Salary}");
            }
            public void GetWorkerInfo(string Name, int Salary, string Position) {
                Console.WriteLine($"Iscinin adi: {Name},pozisiyasi: {Position}, maasi: {Salary}");
            }
        }
    }
}
