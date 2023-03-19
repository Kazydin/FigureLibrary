using FigureLibrary.Abstract;

namespace FigureLibrary.Concrete
{
    public class Circle : IFigure
    {
        public readonly double Radius;

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Некорректный радиус круга", nameof(radius));
            }

            Radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
