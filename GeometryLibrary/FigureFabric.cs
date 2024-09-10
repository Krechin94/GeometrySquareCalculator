using GeometryLibrary.Exceptions;
using GeometryLibrary.Figures;

namespace GeometryLibrary
{
    public static class FigureFabric
    {
        public static Circle CircleCreate()
        {
            Console.WriteLine("Type your radius");
            double radius = RetrieveValue();
            return new Circle(radius);
        }

        public static Triangle TriangleCreate()
        {
            Console.WriteLine("Type length of your sides");

            Console.WriteLine("side1");
            double side1 = RetrieveValue();

            Console.WriteLine("side2");
            double side2 = RetrieveValue();

            Console.WriteLine("side3");
            double side3 = RetrieveValue();

            return new Triangle(side1, side2, side3);
        }

        public static double RetrieveValue()
        {
            double value = double.Parse(Console.ReadLine()!);
            if (value <= 0)
                throw new NegativeValueException("You input negative value");
            else
                return value;
        }
    }
}
