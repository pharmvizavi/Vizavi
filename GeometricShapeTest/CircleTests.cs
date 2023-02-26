using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

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
            var circle = new Circle { Radius = 10 };
            //Act
            var circleSquare = circle.GetArea();

            //Assert
            Assert.AreEqual(314.15926535, circleSquare);
        }
    }
}