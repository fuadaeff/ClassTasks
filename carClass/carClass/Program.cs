namespace carClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", 2021);
            car1.print();
        }
        public class Car
        {
            public string brand;
            public int year;
            public Car(string Brand, int Year) {
                brand = Brand;
                year = Year;
            }
            public void print() {
                Console.WriteLine($"Marka: {brand}, Il: {year}");
            }
        }
    }
}
