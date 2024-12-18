namespace Figure8;

public interface IFigure
{
    public double Perimeter { get; }
    public double CalcArea();
    public bool IsPossible();
}