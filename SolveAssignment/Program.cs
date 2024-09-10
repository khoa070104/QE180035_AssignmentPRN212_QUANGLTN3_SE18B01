namespace SolveAssignment
{
    class Program
    {
        static void Main()
        {
            Execute();
        }
        static void Execute(){
            int choice;
            do{
                Menu(out choice);
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Length: ");
                        double length = double.Parse(Console.ReadLine());
                        Console.Write("Nhập Width: ");
                        double width = double.Parse(Console.ReadLine());
                        var rectangle = CalculateShape(1, length, width);
                        Console.WriteLine($"Rectangle - Perimeter: {rectangle.Item1}, Area: {rectangle.Item2}");
                        break;
                    case 2:
                        Console.Write("Enter edge: ");
                        double side = double.Parse(Console.ReadLine());
                        var square = CalculateShape(2, side);
                        Console.WriteLine($"Square - Perimeter: {square.Item1}, Area: {square.Item2}");
                        break;
                    case 3:
                        Console.Write("Enter a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Enter b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Enter c: ");
                        double c = double.Parse(Console.ReadLine());
                        var triangle = CalculateShape(3, a, b, c);
                        Console.WriteLine($"Triangle - Perimeter: {triangle.Item1}, Area: {triangle.Item2}");
                        break;
                    case 4: System.Console.WriteLine("QUANGLTN3 TOP 1 SERVER!");
                        break;
                    default:
                        Console.WriteLine("Your choice not invalid!");
                        break;
                }
            } while(choice != 4);
        }

        static void Menu(out int choice){
            choice = 5; // Tránh trường hợp nhập chữ ăn exception
            Console.WriteLine("--- SHAPE CALCULATE ---");
            Console.WriteLine("1. Rectange");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Triangle");
            Console.Write("Enter Your Choice: ");
            int.TryParse(Console.ReadLine(),out choice);
        }

        static (double, double) CalculateShape(int shapeType, params double[] dimensions)
        {
            double perimeter = 0, area = 0;
            switch (shapeType)
            {
                case 1: 
                    double length = dimensions[0];
                    double width = dimensions[1];
                    perimeter = 2 * (length + width);
                    area = length * width;
                    break;
                case 2: 
                    double side = dimensions[0];
                    perimeter = 4 * side;
                    area = side * side;
                    break;
                case 3: 
                    double a = dimensions[0];
                    double b = dimensions[1];
                    double c = dimensions[2];
                    perimeter = a + b + c;
                    double s = perimeter / 2;
                    area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                    break;
                default:
                    throw new ArgumentException("Invalid shape type");
            }
            return (perimeter, area);
        }
    }
}
