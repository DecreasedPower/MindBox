namespace FigureArea
{
  public static class FigureAreaCalculator
  {
    public static double CalculateArea(this IFigure figure)
    {
      return figure.GetArea();
    }

    // Как получать типы в рантайме? Консоль? Как получать информацию о сторонах/радиусу? Опять консоль?
    // Рефлексия через object? Меняем в 5 строчке IFigure на object и в 7 приводим к IFigure
  }
}
