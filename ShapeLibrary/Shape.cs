using System;
using System.Linq;

namespace ShapeLibrary
{
    /// <summary>
    /// абстрактный класс фигуры
    /// </summary>
    public abstract class Shape
    {
        public const double pi = Math.PI;
        /// <summary>
        /// абстрактный метод для получения периметра
        /// </summary>
        public abstract double GetPerimeter();

        /// <summary>
        /// абстрактный метод для получения площади
        /// </summary>
        public abstract double GetArea();       
    }

    /// <summary>
    /// производный класс прямоугольника
    /// </summary>    
    public class Rectangle: Shape
    {            
        public float Width { get; }
        
        public float Height { get; }
        
        /// <summary>
        /// Прямоугольник. Конструктор с параметрами
        /// </summary>
        /// <param name="width">Первая сторона</param>
        /// <param name="height">Вторая сторона</param>       
        /// <exception cref="ArgumentOutOfRangeException">Если сторона треугольника имеет отрицательное значение</exception>
        public Rectangle(float width, float height)
        {
            if (width < 0 || height < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");

            Width = width;
            Height = height;            
        }

        /// <summary>
        /// Переопрелеление. Вычисление периметра прямоугольника
        /// </summary>
        public override double GetPerimeter() => Width * 2 + Height * 2;

        /// <summary>
        /// Переопрелеление. Вычисление площади прямоугольника
        /// </summary>
        public override double GetArea() => Width * Height;
    }

    /// <summary>
    /// производный класс круга
    /// </summary>
    /// <param name="Radius">Радиус круга</param> 
    /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение или не является числом</exception>
    public class Circle : Shape
    {       
        public double Radius { get; }
        
        /// <summary>
        /// Круг. Конструктор с параметрами
        /// </summary>
        /// <param name="radius">Радиус круга</param> 
        /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("Радиус не может быть отрицательным");

            Radius = radius;
        }

        /// <summary>
        /// Переопрелеление. Вычисление длины окружности круга
        /// </summary>
        public override double GetPerimeter() => Radius * 2 * pi;

        /// <summary>
        /// Переопрелеление. Вычисление площади круга
        /// </summary>
        public override double GetArea() => Radius * Radius * pi;
    }

    /// <summary>
    /// производный класс треугольника
    /// </summary>   
    public class Triangle : Shape
    {        
        public float A { get; }
        
        public float B { get; }
       
        public float C { get; }

        /// <summary>
        /// Треугольник. Конструктор с параметрами
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <exception cref="ArgumentOutOfRangeException">Если сторона треугольника имеет отрицательное значение</exception>
        /// <exception cref="ArgumentOutOfRangeException">Если любря сторона треугольника Больше суммы двух других сторон</exception>
        public Triangle(float a, float b, float c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");
             if (2 * new[] { a, b, c }.Max() > (c + a + b ))
                throw new ArgumentOutOfRangeException("В треугольнике любая сторона должна быть не болдьше суииы двух других");

            A = a;
            B = b;
            C = c;           
        }

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool CheckIsRightAngled()
        {
            var maxSide = new[] { A, B, C }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == A * A + B * B + C * C;
        }

        /// <summary>
        /// Переопрелеление. Вычисление периметра треугольника
        /// </summary>
        public override double GetPerimeter() => A + B + C;

        /// <summary>
        /// Переопрелеление. Вычисление площади треугольника
        /// </summary>
        public override double GetArea()
        {
            if (CheckIsRightAngled())
                return new[] { A * B, A * C, B * C }.Min() / 2d;
            else
            {
                double p = (A + B + C) / 2d;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }
    }   
}
