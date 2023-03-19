using FigureLibrary.Abstract;
using FigureLibrary.Concrete;

namespace FigureLibrary.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetSquare_Success()
        {
            // Arrange
            double radius = 10;
            IFigure figure = new Circle(radius);
            double expectedValue = Math.PI * Math.Pow(radius, 2);

            // Act
            double square = figure.GetSquare();

            // Assert
            Assert.That(square, Is.EqualTo(expectedValue));
        }

        [Test]
        public void CreateCircle_ThrowsArgumentException()
        {
            // Act
            var ex = Assert.Throws<ArgumentException>(() => new Circle(-10));

            //Assert
            StringAssert.Contains("Некорректный радиус круга", ex.Message);
        }

        [Test]
        public void CreateCircle_ZeroRadiusAndThrowsArgumentException()
        {
            // Act
            var ex = Assert.Throws<ArgumentException>(() => new Circle(0));

            //Assert
            StringAssert.Contains("Некорректный радиус круга", ex.Message);
        }

    }
}