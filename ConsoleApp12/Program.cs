using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class MyMathOperation
    {
        public static double rad { get; set; }
        public static double c { get; set; }


        // Возвращает Радиан
        public static double SqrCircle(double rad)
        {

            return Math.PI * rad * rad;
        }

        public static double LongCircle(double rad)
        {
            return 2 * Math.PI * rad;
        }
        

    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите радиус: ");
            double rad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите x1: ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите y1: ");
            double y1 = Convert.ToInt32(Console.ReadLine());                        
            double x0 = 0;
            double y0 = 0;
            double a = y0 + y1;
            double b = x0 + x1;            
            double c = Math.Sqrt(Math.Abs(a * a) + (b * b));
            if (c>rad)
            {
                Console.WriteLine("Площадь круга = {0}, длина окружности = {1} точка х1,у1 не входит в круг", MyMathOperation.SqrCircle(rad), MyMathOperation.LongCircle(rad));
            }
            else if (c == rad)
            {
                Console.WriteLine("Площадь круга = {0}, длина окружности = {1} точка х1,у1 на окружности", MyMathOperation.SqrCircle(rad), MyMathOperation.LongCircle(rad));
            }
            else
            {
                Console.WriteLine("Площадь круга = {0}, длина окружности = {1} точка х1,у1 внутри круга", MyMathOperation.SqrCircle(rad), MyMathOperation.LongCircle(rad));
            }
            
             Console.ReadLine();
            Console.ReadKey();
        }
    }
}
