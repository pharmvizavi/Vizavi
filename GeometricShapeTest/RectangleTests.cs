using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace GeometricShape.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        /// <summary>
        /// Тестируем вычисление периметра прямогольника
        /// </summary>
        [TestMethod()]
        public void GetPerimeterTest()
        {
            //Arrange
            var rectanle = new Rectangle(14.5f, 18.2f);
            //Act
            var rectanlePerimeter = rectanle.GetPerimeter();

            //Assert
            Assert.AreEqual(65.4f, rectanlePerimeter);
        }

        /// <summary>
        /// Тестируем вычисление пплощади прямогольника
        /// </summary>
        [TestMethod()]
        public void GetAreaTest()
        {
            //Arrange
            var rectanle = new Rectangle(10.5f, 20.2f);
            //Act
            var rectanleArea = rectanle.GetArea();

            //Assert
            Assert.AreEqual(212.1f, rectanleArea);
        }

        /// <summary>
        /// Тестируем конструктор прямоугольника
        /// </summary>
        [TestMethod()]
        public void RectangleTest()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rectangle(-7, 5));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Rectangle(7, -5));
        }
    }
}