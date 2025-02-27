namespace calculatorClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Komponentleri daxil edin:");
            Console.WriteLine("Ilk component:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci component:");
            int b = int.Parse(Console.ReadLine());
            Console.Clear();
            Calculator calc1 = new Calculator(a,b);
            calc1.Sum(a,b);
            calc1.Mul(a,b);
        }
        public class Calculator {
            public int first_component;
            public int second_component;
            public Calculator(int a, int b) {
                first_component = a;
                second_component = b;
            }
            public void Sum(int x, int y) {
                int sum = x + y;
                Console.WriteLine($"{x} ve {y}-in cemi: {sum}");
            }
            public void Mul(int x, int y) { 
                int mul = x*y;
                Console.WriteLine($"{x} ve {y}-in hasili: {mul}");
            }
                    
        }
    }
}
