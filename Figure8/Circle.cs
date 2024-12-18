namespace Figure8;

public class Circle : IFigure
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
        Perimeter = 2 * _radius * Math.PI;
    }

    public double Perimeter { get; }

    public double CalcArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}