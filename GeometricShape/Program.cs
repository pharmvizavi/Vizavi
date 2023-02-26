using System;
using ShapeLibrary;

namespace GeometricShape
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, width, height;
            double radius;
            Console.Write("Введите сторону треугольника a = ");
            a = Vvod();
            //a = float.Parse(Console.ReadLine());
            Console.Write("Введите  сторону треугольника b = ");
            b = Vvod();
            //b = float.Parse(Console.ReadLine());
            Console.Write("Введите  сторону треугольника c = ");
            c = VvodTriangle(a, b);
            //c = float.Parse(Console.ReadLine());            
            var triangle = new Triangle { A = a, B = b, C = c };
            PrintShape(triangle); // Perimeter: 12  Area: 6
                                  
            //var triangle1 = new Triangle { A = 4, B = 7, C = 9 };
            //PrintShape(triangle1); // Perimeter: 12  Area: 6         

            Console.Write("Введите ширину прямоугольника  width = ");
            width = Vvod();
            //width = float.Parse(Console.ReadLine());
            Console.Write("Введите  высоту прямоугольника height = ");
            height = Vvod();
            //height = float.Parse(Console.ReadLine());
            var rectanle = new Rectangle { Width = width, Height = height };
            PrintShape(rectanle); // Perimeter: 80   Area: 400
           
            Console.Write("Введите радиус окружности radius = ");
            radius = Vvod();
            //radius = double.Parse(Console.ReadLine());
            var circle = new Circle { Radius = radius };           
            PrintShape(circle); // Perimeter: 1256  Area: 125600

            void PrintShape(Shape shape)
            {
                Console.WriteLine("Shape: {0}  Perimeter: {1:0.00}  Area: {2:0.00}", shape, shape.GetPerimeter(), shape.GetArea());
                Console.WriteLine("Shape: {0}  Perimeter: {1}  Area: {2}", shape, shape.GetPerimeter(), shape.GetArea());
            }

            Console.ReadLine();
        }

        static float Vvod()
        {
            while (true)
            {
                float c;
                if (float.TryParse(Console.ReadLine(), out c) && c > 0)
                    return c;
                else
                    Console.Write("Необходимо ввести число больше 0. Введите еще раз: ");
            }
        }

        static float VvodTriangle(float a, float b)
        {
            while (true)
            {
                float c;
                if (float.TryParse(Console.ReadLine(), out c) && c > 0 && ((c + c) < (c + a + b )))
                    return c;
                else
                {
                    if ( c <= 0 )                    
                        Console.Write("Необходимо ввести число больше 0. Введите еще раз: ");
                    else
                        Console.Write("В треугольнике любая сторона должна быть меньше суииы двух других. Введите еще раз: ");
                }
                    
            }

        }
    }
}
