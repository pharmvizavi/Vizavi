using System;
using System.Linq;

namespace ShapeLibrary
{
    /// <summary>
    /// абстрактный класс фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// абстрактный метод для получения периметра
        /// </summary>
        public abstract double GetPerimeter();

        /// <summary>
        /// абстрактный метод для получения площади
        /// </summary>
        public abstract double GetArea();

        /// <summary>
        /// Вычисление корня квадратного по методу Ньютона
        /// </summary>
        public double sqrt(double number)
        {
            double t;
            double squareRoot = number / 2;
            do
            {
                t = squareRoot;
                squareRoot = (t + (number / t)) / 2;
            } while ((t - squareRoot) != 0);

            return squareRoot;
        }
    }
    /// <summary>
    /// производный класс прямоугольника
    /// </summary>
    /// <param name="Width">Первая сторона</param>
    /// <param name="Height">Вторая сторона</param>
    /// <exception cref="ArgumentOutOfRangeException">Если сторона имеет отрицательное значение или не является числом</exception>    
    public class Rectangle : Shape
    {
        float width = 0;
        float height = 0;
        public float Width
        {
            get { return width; }
            set
            {
                if (value <= 0 || float.IsNaN(value))
                    throw new ArgumentOutOfRangeException("Сторона должна быть числом больше 0");
                else
                    width = value;
            }
        }
        public float Height
        {
            get { return height; }
            set
            {
                if (value <= 0 || float.IsNaN(value))
                    throw new ArgumentOutOfRangeException("Сторона должна быть числом больше 0");
                else
                    height = value;
            }
        }

        /// <summary>
        /// переопрелеление вычисления периметра прямоугольника
        /// </summary>
        public override double GetPerimeter() => width * 2 + height * 2;

        /// <summary>
        /// переопрелеление вычисления площади прямоугольника
        /// </summary>
        public override double GetArea() => width * height;
    }

    /// <summary>
    /// производный класс круга
    /// </summary>
    /// <param name="Radius">Радиус круга</param> 
    /// <exception cref="ArgumentOutOfRangeException">Если радиус круга имеет отрицательное значение или не является числом</exception>

    public class Circle : Shape
    {
        double radius = 0;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0 || double.IsNaN(value))
                    throw new ArgumentOutOfRangeException("Радиус должен быть числом больше 0");
                else
                    radius = value;
            }
        }

        /// <summary>
        /// переопрелеление вычисления длины окружности круга
        /// </summary>
        public override double GetPerimeter() => radius * 2 * 3.1415926535;

        /// <summary>
        /// переопрелеление вычисления площади круга
        /// </summary>
        public override double GetArea() => radius * radius * 3.1415926535;
    }

    /// <summary>
    /// производный класс треугольника
    /// </summary>
    /// <param name="A">Первая сторона</param>
    /// <param name="B">Вторая сторона</param>
    /// <param name="C">Третья сторона</param>
    /// <exception cref="ArgumentOutOfRangeException">Если сторона имеет отрицательное значение или не является числом</exception> 
    public class Triangle : Shape
    {
        float a = 0;
        float b = 0;
        float c = 0;
        public float A
        {
            get { return a; }
            set
            {
                if (value <= 0 || double.IsNaN(value))
                    throw new ArgumentOutOfRangeException("Сторона должна быть числом больше 0");
                else
                    a = value;
            }
        }
        public float B
        {
            get { return b; }
            set
            {
                if (value <= 0 || double.IsNaN(value))
                    throw new ArgumentOutOfRangeException("Сторона должна быть числом больше 0");
                else
                    b = value;
            }
        }
        public float C
        {
            get { return c; }
            set
            {
                if (value <= 0 || double.IsNaN(value))
                    throw new ArgumentOutOfRangeException("Сторона должна быть числом больше 0");
                else
                    c = value;
            }
        }

        /// <summary>
        /// Проверить, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool CheckIsRightAngled()
        {
            var maxSide = new[] { a, b, c }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == a * a + b * b + c * c;
        }

        /// <summary>
        /// переопрелеление вычисления периметра треугольника
        /// </summary>
        public override double GetPerimeter() => a + b + c;

        /// <summary>
        /// переопрелеление вычисления площади треугольника
        /// </summary>
        public override double GetArea()
        {
            if (CheckIsRightAngled())
                return new[] { a * b, a * c, b * c }.Min() / 2d;
            else
            {
                double p = (a + b + c) / 2d;
                return sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }

    /*
    public class Triangle1(float a, float b, float c) : Ttiangle
        {
        A = a;
        B = b;
        C = c;
        }
    */
}
