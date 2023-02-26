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
            Console.Write("Введите  сторону треугольника b = ");
            b = Vvod();            
            Console.Write("Введите  сторону треугольника c = ");
            c = VvodTriangle(a, b);                        
            var triangle = new Triangle(a, b, c );
            PrintShape(triangle); 
                                  
            //var triangle1 = new Triangle(3, 7, 4);
            //PrintShape(triangle1); // Perimeter: 12  Area: 6         

            Console.Write("Введите ширину прямоугольника  width = ");
            width = Vvod();            
            Console.Write("Введите  высоту прямоугольника height = ");
            height = Vvod();            
            var rectanle = new Rectangle(width, height );
            PrintShape(rectanle); 
            
            Console.Write("Введите радиус окружности radius = ");
            radius = Vvod();            
            var circle = new Circle(radius);           
            PrintShape(circle); 

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
