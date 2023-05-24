namespace FigureArea
{
  public class Triangle : IFigure
  {
    private double[] Sides { get; }

    public Triangle(params double[] sides)
    {
      Sides = sides.OrderBy(s => s).ToArray();
    }

    public double GetArea()
    {
      if (Sides.Length != 3)
      {
        throw new ArgumentException("Incorrect amount of sides");
      }

      if (Sides[0] > Sides[1] + Sides[2] || Sides[1] > Sides[0] + Sides[2] || Sides[2] > Sides[0] + Sides[1])
      {
        throw new ArgumentException("Incorrect sides provided.");
      }

      if (Math.Abs(Math.Pow(Sides[2], 2) - (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2))) == 0)
      {
        return Math.Round(0.5 * Sides[0] * Sides[1], 2);
      }
      else
      {
        var p = 0.5 * Sides.Sum(x => x);
        return Math.Round(Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2])), 2);
      }
    }
  }
}
