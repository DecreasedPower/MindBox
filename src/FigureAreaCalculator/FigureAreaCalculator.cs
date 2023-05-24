namespace FigureArea
{
  public static class FigureAreaCalculator
  {
    // Вариант на тему вычисления плозади без знания типа в compile-time
    // Как получать типы в рантайме? Консоль? Как получать информацию о сторонах/радиусу? Опять консоль?

    public static double CalculateArea()
    {
      var figureType = Console.ReadLine();
      if (string.IsNullOrEmpty(figureType))
      {
        throw new ArgumentException("Incorrect figure type provided");
      }

      IFigure? figure = null;
      switch (figureType.ToLower())
      {
        case "circle":
          {
            if (!double.TryParse(Console.ReadLine(), out double radius))
            {
              throw new ArgumentException("Incorrect radius provided");
            }

            figure = new Circle(radius);
            break;
          }
        case "triangle":
          {
            var sides = new double[3];
            for (int i = 0; i < sides.Length; i++)
            {
              if (!double.TryParse(Console.ReadLine(), out double side))
              {
                throw new ArgumentException("Incorrect side provided");
              }

              sides[i] = side;
            }

            figure = new Triangle(sides);
            break;
          }
      }

      if (figure is null)
      {
        throw new ArgumentException("Wrong figure provided.");
      }

      return figure.GetArea();
    }
  }
}
