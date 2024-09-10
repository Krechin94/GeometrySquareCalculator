using GeometryLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Figures
{
    public class Triangle : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
            if (_side1 <= 0|| _side2 <= 0 || _side3 <= 0)
                throw new NegativeValueException("You input negative value");
        }

        public double CalculatingSquare()
        {
            double halfPerimetr = (_side1 + _side2 + _side3) / 2;
            double square = Math.Sqrt(halfPerimetr * (halfPerimetr - _side1) * (halfPerimetr - _side2) * (halfPerimetr - _side3));
            return square;
        }

        public string CheckingOnRectangularTriangle()
        {
            List<double> list = new List<double>() { _side1, _side2, _side3 };
            list.Sort();
            if (Math.Pow(list[2], 2) == Math.Pow(list[1], 2) + Math.Pow(list[0], 2))
                return "Rectangular";
            else
                return "nonRectangular";
        }

        public override string ToString()
        {
            return $"Square = {CalculatingSquare()}, triangle is {CheckingOnRectangularTriangle()}";
        }
    }
}
