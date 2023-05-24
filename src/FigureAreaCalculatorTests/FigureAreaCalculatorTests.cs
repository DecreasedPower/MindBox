using FigureArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FigureAreaCalculatorTests
{
  [TestClass]
  public class FigureAreaCalculatorTests
  {
    [TestMethod]
    public void ShouldReturnCorrectAreaWhenRadiusOk()
    {
      var expectedArea = 314.16;

      var circle = new Circle(10);
      var actualArea = FigureAreaCalculator.CalculateArea(circle);

      Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void ShouldReturnZeroWhenRadiusZero()
    {
      var expectedArea = 0;

      var circle = new Circle(0);
      var actualArea = FigureAreaCalculator.CalculateArea(circle);

      Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void ShouldReturnArgumentExceptionWhenNegativeRadius()
    {
      var circle = new Circle(-0.1);

      Assert.ThrowsException<ArgumentException>(() => FigureAreaCalculator.CalculateArea(circle));
    }

    [TestMethod]
    public void ShouldReturnCorrectAreaWhenTriangleIsNotRightAndCorrect()
    {
      var expectedArea = 3.9;

      var triangle = new Triangle(3, 3, 3);
      var actualArea = FigureAreaCalculator.CalculateArea(triangle);

      Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void ShouldReturnCorrectAreaWhenTriangleIsRightAndCorrect()
    {
      var expectedArea = 6;

      var triangle = new Triangle(3, 4, 5);
      var actualArea = FigureAreaCalculator.CalculateArea(triangle);

      Assert.AreEqual(expectedArea, actualArea);
    }

    [TestMethod]
    public void ShouldReturnArgumentExceptionWhenTwoSides()
    {
      var triangle = new Triangle(3, 4);

      Assert.ThrowsException<ArgumentException>(() => FigureAreaCalculator.CalculateArea(triangle));
    }

    [TestMethod]
    public void ShouldReturnArgumentExceptionWhenIncorrectSides()
    {
      var triangle = new Triangle(3, 4, 100);

      Assert.ThrowsException<ArgumentException>(() => FigureAreaCalculator.CalculateArea(triangle));
    }
  }
}