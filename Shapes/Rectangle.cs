namespace Shapes;

public class Rectangle : Shape
{
    private double width, length;

    public Rectangle(double width, double length, double x, double y) : base(x, y)
    {
        this.width = width;
        this.length = length;
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public override double Area()
    {
        return width * length;
    }
}