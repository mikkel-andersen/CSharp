using System.Drawing;

namespace Shapes;

public class Circle : Shape
{
    private double r;

    public Circle(double x, double y, double r) : base(x, y)
    {
        this.r = r;
    }

    public double R
    {
        get { return r; }
        set { r = value; }
    }

    public Point getCenter()
    {
        return new Point((int)(X + r), (int)(Y + r));
    }

    public override double Area()
    {
        return Double.Pi * Math.Pow(r, 2);
    }
}