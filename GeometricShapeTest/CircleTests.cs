using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace GeometricShape.Tests
{
    [TestClass()]
    public class CircleTests
    {
        /// <summary>
        /// Тестируем вычисление площади круга
        /// </summary>
        [TestMethod()]
        public void GetAreaTest()
        {
            //Arrange
            var circle = new Circle(10d);
            //Act
            var circleSquare = circle.GetArea();

            //Assert
            Assert.AreEqual(314.1592653589793, circleSquare);
        }

        /// <summary>
        /// Тестируем вычисление длины окружности
        /// </summary>
        [TestMethod()]
        public void GetPerimetrTest1()
        {
            //Arrange
            var circle = new Circle(10d);
            //Act
            var circumference = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(62.83185307179586, circumference);
        }

        /// <summary>
        /// Тестируем конструктор круга
        /// </summary>
        [TestMethod()]
        public void CircleTest()
        {
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-7));            
        }
    }
}