using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShape.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        /// <summary>
        /// Тестируем вычисление площади тиугольника
        /// </summary>
        [TestMethod()]
        public void GetAreaTest()
        {
            //Arrange
            var triangle = new Triangle { A = 3, B = 4, C = 5 };
            //Act
            var triangleSquare = triangle.GetArea();
            //Assert
            Assert.AreEqual(6, triangleSquare);

        }
    }
}