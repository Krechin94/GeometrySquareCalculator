using GeometryLibrary;
namespace GeometrySquareCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of figure\n 1 - Circle\n 2 - Triangle");
            try
            {
                int typeOfFigure = int.Parse(Console.ReadLine()!);

                switch (typeOfFigure)
                {
                    case 1:
                        Console.WriteLine(FigureFabric.CircleCreate().ToString());
                        break;

                    case 2:
                        Console.WriteLine(FigureFabric.TriangleCreate().ToString());
                        break;
                    default:
                        Console.WriteLine("Please choose from list");
                        break;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
