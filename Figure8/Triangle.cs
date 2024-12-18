namespace Figure8;

public class Triangle : IFigure
{
    private double[] _sides;
    public double Perimeter => _sides[0] + _sides[1] + _sides[2];
    public double SemiPerimeter => Perimeter / 2;

    public Triangle(double[] sides)
    {
        _sides = sides;
        Array.Sort(_sides);
    }

    public double CalcArea()
    {
        return Math.Sqrt(SemiPerimeter *
                         SemiPerimeterWithoutSide(_sides[0]) *
                         SemiPerimeterWithoutSide(_sides[1]) *
                         SemiPerimeterWithoutSide(_sides[2]));
    }

    public bool IsRightTriangle()
    {
        return Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2);
    }

    private double SemiPerimeterWithoutSide(double side)
    {
        return SemiPerimeter - side;
    }
}