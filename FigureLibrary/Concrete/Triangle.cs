using FigureLibrary.Abstract;

namespace FigureLibrary.Concrete
{
    public class Triangle : IFigure
    {
        public readonly double SideA;

        public readonly double SideB;

        public readonly double SideC;

        public readonly bool IsRightTriangle;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new ArgumentException("Некорретное значение стороны", nameof(sideA));
            }

            if (sideB <= 0)
            {
                throw new ArgumentException("Некорретное значение стороны", nameof(sideB));
            }

            if (sideC <= 0)
            {
                throw new ArgumentException("Некорретное значение стороны", nameof(sideC));
            }

            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideC + sideA <= sideB)
            {
                throw new ArgumentException("Заданного треугольника не существует");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            IsRightTriangle = GetIsRightTriangle();
        }

        public double GetSquare()
        {
            double p = (SideA + SideB + SideC) / 2;

            // Формула Герона
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        private bool GetIsRightTriangle()
        {
            // Формула Пифагора
            return (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2) ||
                Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2) ||
                Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2));
        }
    }
}
