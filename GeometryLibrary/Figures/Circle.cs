using GeometryLibrary.Exceptions;

namespace GeometryLibrary.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;
        public Circle(double radius)
        {
            _radius = radius;
            if (radius <= 0)
                throw new NegativeValueException("You input negative value");
        }

        public double CalculatingSquare()
        {
            double square = _radius * _radius * Math.PI;
            return square;
        }

        public override string ToString()
        {
            return $"Square of your circle = {CalculatingSquare()}";
        }
    }
}
