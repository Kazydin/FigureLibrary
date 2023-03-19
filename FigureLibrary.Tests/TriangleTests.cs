using FigureLibrary.Abstract;
using FigureLibrary.Concrete;

namespace FigureLibrary.Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSquare_Success()
        {
            // Arrange
            double a = 10;
            double b = 12;
            double c = 15;

            IFigure figure = new Triangle(a, b, c);

            double p = (a + b + c) / 2;
            double expectedValue = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            // Act
            double square = figure.GetSquare();

            // Assert
            Assert.That(square, Is.EqualTo(expectedValue));
        }

        [Test]
        public void CreateTriangle_ThrowsArgumentException()
        {
            // Arrange
            double a = 10;
            double b = 20;
            double c = 30;

            // Act
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));

            // Assert
            StringAssert.Contains("Заданного треугольника не существует", ex.Message);
        }

        [Test]
        public void CreateTriangle_ZeroSideThrowsArgumentException()
        {
            // Arrange
            double a = 10;
            double b = -1;
            double c = 10;

            // Act
            var ex = Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));

            // Assert
            StringAssert.Contains("Некорретное значение стороны", ex.Message);
        }

        [Test]
        public void TriangleIsRight()
        {
            // Arrange
            double a = 7;
            double b = 24;
            double c = 25;

            Triangle figure = new Triangle(a, b, c);

            // Assert
            Assert.IsTrue(figure.IsRightTriangle);
        }

        [Test]
        public void TriangleIsNotRight()
        {
            // Arrange
            double a = 10;
            double b = 10;
            double c = 10;

            Triangle figure = new Triangle(a, b, c);

            // Assert
            Assert.IsFalse(figure.IsRightTriangle);
        }
    }
}
