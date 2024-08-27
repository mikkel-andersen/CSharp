using Shapes;

class Program
{
    static void Main(string[] args)
    {
        var circle1 = new Circle(4, 5, 4);
        var circle2 = new Circle(1, 2, 3);
        var rectangle1 = new Rectangle(10, 10, 6, 6);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle1);
        shapes.Add(circle2);
        shapes.Add(rectangle1);

        foreach (var shape in shapes)
        {
            Console.WriteLine("Shape med punkterne " + shape.X + ", " + shape.Y);

            if (shape is Circle)
            {
                Console.WriteLine("Cirkel med radius " + ((Circle)shape).R);
                Console.WriteLine("Har et areal på " + shape.Area() + "\n");
               
            }
            else if (shape is Rectangle)
            {
                Console.WriteLine("Rektangel med " +((Rectangle)shape).Width +
                                  " bredde og " + ((Rectangle)shape).Length + " længde");
                Console.WriteLine("Har et areal på " + shape.Area() + "\n");
         
            }
        }

    }
}