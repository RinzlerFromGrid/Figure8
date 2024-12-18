using Figure8;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CircleArea()
    {
        const double area = Math.PI * 5 * 5;
        var circle = new Circle(5);
        Assert.AreEqual(area, circle.CalcArea());
    }

    [Test]
    public void TriangleArea()
    {
        const double area = 4 * 3 / 2;
        var triangle = new Triangle([5, 4, 3]);
        Assert.AreEqual(area, triangle.CalcArea());
    }

    [Test]
    public void TriangleIsRight()
    {
        var triangleOne = new Triangle([5, 4, 3]);
        var triangleTwo = new Triangle([4, 5, 3]);
        var triangleTree = new Triangle([3, 4, 5]);
        Assert.IsTrue(triangleOne.IsRightTriangle() &&
                      triangleTwo.IsRightTriangle() &&
                      triangleTree.IsRightTriangle());
    }
}