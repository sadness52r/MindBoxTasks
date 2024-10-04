namespace FiguresMetrics
{
    public static class FigureFactory
    {
        public static IFigure CreateFigure(string figureType, params double[] parameters)
        {
            switch (figureType.ToLower())
            {
                case "circle":
                    if (parameters.Length != 1)
                        throw new ArgumentException("It is need a 1 parameter for circle");
                    return new Circle(parameters[0]);
                case "triangle":
                    if (parameters.Length != 3)
                        throw new ArgumentException("It is need 3 parameters for triangle");
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                default:
                    throw new NotSupportedException($"Figure {figureType} does not support!");
            }
        }
    }
}
