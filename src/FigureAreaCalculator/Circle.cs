namespace FigureArea
{
  public class Circle : IFigure
  {
    private readonly double _radius;

    public Circle(double radius)
    {
      _radius = radius;
    }

    public double GetArea()
    {
      if (_radius < 0)
      {
        throw new ArgumentException("Circle radius must be positive");
      }

      return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
    }
  }
}
