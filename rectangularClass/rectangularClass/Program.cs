namespace rectangularClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle figure = new Rectangle(5,10);
            figure.CalculateArea(5, 10);
            figure.CalculatePerimetr(5, 10);
        }
        public class Rectangle {
            public int Width;
            public int Height;
            public Rectangle(int width, int height) {
                if (width > 0 && height > 0)
                {
                    Width = width;
                    Height = height;
                }
                else 
                {
                    Console.WriteLine("Cannot be negative.Defined as zero.");
                    Width = 0;
                    Height = 0;
                }
            }
            public void CalculateArea(int width, int height) {
                int area = width * height;
                Console.WriteLine($"Area of rectangular is {area}");
            }
            public void CalculatePerimetr(int width, int height) {
                int perimetr = 2 * (width + height);
                Console.WriteLine($"Perimetr of rectangular is {perimetr}");
            }

            
        }
    }
}
