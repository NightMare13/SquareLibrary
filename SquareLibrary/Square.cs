using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SquareLibrary
{
    public static class Square
    {
        public static double GetSquareForRightTriangle(double cathetA, double cathetB, double hypotenuse)
            => 1.0 / 2.0 * cathetA * cathetB;

        public static double GetSquareForCircle(double radius)
            => Math.PI * Math.Pow(radius, 2);

        public static double GetSquareForUnknownFigure(double x1, double x2 = 0, double x3 = 0)
        {
            if (x2 != 0 && x3 != 0)//если передано три параметра, то считаем площадь для прямоугольного треугольника
            {
                double a = 0, b = 0, c = 0;
                
                if (x1 > x2 && x1 > x3)
                {
                    c = x1;
                    a = x2;
                    b = x3;
                }
                else if (x2 > x1 && x2 > x3)
                {
                    c = x2;
                    a = x1;
                    b = x3;
                }
                else if (x3 > x1 && x3 > x2)
                {
                    c = x3;
                    a = x1;
                    b = x2;
                }
                return GetSquareForRightTriangle(a, b, c);
            }

            if(x2 == 0 && x3 ==0)// если передан один параметр, то считаем площадь для круга
            {
                return GetSquareForCircle(x1);
            }

            return -1;//в случае если не возможно определить тип фигуры
        }

    }
}
