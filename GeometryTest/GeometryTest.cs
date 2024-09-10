using GeometryLibrary;
using GeometryLibrary.Figures;
using GeometryLibrary.Exceptions;

namespace GeometryTest
{
    [TestClass]
    public class GeometryTest
    {
        [TestMethod]
        public void TestTriangleSquare()
        {
            var triangle = new Triangle(3,4,5);
            Assert.AreEqual(6,triangle.CalculatingSquare());
        }

        [TestMethod] public void TestTriangleRectangularity()
        {
            var triangle = new Triangle(3,4,5);
            Assert.AreEqual<string>("Rectangular",triangle.CheckingOnRectangularTriangle());
        }

        [TestMethod]
        public void TestCircleSquare() 
        {
            var circle = new Circle(12);
            Assert.AreEqual (452.3893421169302, circle.CalculatingSquare());
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void TestWrongInputCircle(double radius)
        {
            Assert.ThrowsException<NegativeValueException>(() =>
            {
                new Circle(radius);
            });
        }

        [TestMethod]
        [DataRow(-1, 10, 1)]
        [DataRow(1, -1, 10)]
        [DataRow(10, 10, -1)]
        public void TestWrongInputTriangle(double side1, double side2, double side3)
        {
            Assert.ThrowsException<NegativeValueException>(() => {
                new Triangle(side1, side2, side3);
            });
        }
    }
}