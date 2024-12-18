using Figure8;

//Легкость добавления других фигур
public class Square(double side) : IFigure
{
    private double _side = side;
    public double Perimeter { get; } = side * 4;

    public double CalcArea()
    {
        return _side * _side;
    }

    public bool IsPossible()
    {
        return _side > 0;
    }
}
public class Rect(double sideA, double sideB) : IFigure
{
    private double _sideA = sideA;
    private double _sideB = sideB;
    public double Perimeter { get; } = sideA * 2 + sideB * 2;

    public double CalcArea()
    {
        return _sideA * _sideB;
    }

    public bool IsPossible()
    {
        return _sideA > 0 && _sideB > 0;
    }
}

internal static class Program
{
    public static void Main(string[] args)
    {
        var random = new Random();

        //Вычисление площади фигуры без знания типа фигуры в compile-time
        var figure = GetRandomFigure(random);
        var area = figure.CalcArea();
        var type = figure.GetType();
        Console.WriteLine($"Figure type is {type}, Area equal {area}");
    }

    private static IFigure GetRandomFigure(Random random)
    {
        return random.Next(1, 4) switch
        {
            1 => new Square(3),
            2 => new Rect(3, 4),
            3 => new Circle(3),
            4 => new Triangle([3, 5, 4]),
            _ => throw new Exception("Unknown figure type")
        };
    }
}