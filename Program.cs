/*2.В решение добавить проект, 
 * реализовать перегрузку методов, 
 * операторов и преобразование типов*/

using System;
using System.Threading.Channels;

namespace OverLoading
{
    //Перегрузка операторов
    struct Point
    {
        public int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.x + b.x, a.y + b.y);
        }
    }
    class Programm
    {
        //Перегрузка методов
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        //преобразование типов

        public class Kg
        {
            public double Value { get; set; }

            public Kg(double value)
            {
                Value = value;
            }

            //Неяновное преобразование 
            public static implicit operator Gram(Kg kg)
            {
                return new Gram(kg.Value * 1000);
            }

            //Явное преобразование
            public static explicit operator Kg(Gram gram)
            {
                return new Kg(gram.Value / 1000);
            }

            public override string ToString()
            {
                return $"{Value} кг";
            }
        }

        public class Gram
        {
            public double Value { get; set; }

            public Gram(double value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return $"{Value} г";
            }
        }


        static void Main(string[] args)
        {

            //Перегрузка методов
            int result = Sum(1, 2, 5);
            Console.WriteLine($"{result}\n");


            //Перегрузка операторов
            Point a = new Point(42, 52);
            Point b = new Point(9, 11);
            Point c = a + b;
            Console.WriteLine("Точка c: x = {0}, y = {1}", c.x, c.y);



            Kg kg = new Kg(1.5);
            //Неявное 
            Gram g = kg;
            Console.WriteLine(g);

            Gram gram = new Gram(4200);

            //Явное
            Kg kgg = (Kg)gram;
            Console.WriteLine(kgg);
        }
    }

}