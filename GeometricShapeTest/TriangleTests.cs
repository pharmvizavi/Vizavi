using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;

namespace GeometricShape.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        /// <summary>
        /// Тестируем вычисление площади треугольника
        /// </summary>
        [TestMethod()]
        public void GetAreaTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 5);
            //Act
            var triangleSquare = triangle.GetArea();
            //Assert
            Assert.AreEqual(6, triangleSquare);
        }

        /// <summary>
        /// Тестируем прямоугольность треугольника
        /// </summary
        [TestMethod()]
        public void CheckIsRightAngledTest()
        {
            //Arrange
            var triangle = new Triangle(20, 15, 25);
            //Act
            var triangleRight = triangle.CheckIsRightAngled();
            //Assert
            Assert.AreEqual(true, triangleRight);
        }

        /// <summary>
        /// Тестируем вычисление периметра треугольника
        /// </summary>
        [TestMethod()]
        public void GetPerimetrTest()
        {
            //Arrange
            var triangle = new Triangle(18, 12, 25);
            //Act
            var trianglePerimeter = triangle.GetPerimeter();
            //Assert
            Assert.AreEqual(55, trianglePerimeter);
        }

        /// <summary>
        /// Тестируем конструктор треугольника
        /// </summary>
        [TestMethod()]
        public void TriangleTest()
        {  
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(8, 22, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(8, -12, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-8, 12, 10));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(8, 12, -10));
        }
    }
}