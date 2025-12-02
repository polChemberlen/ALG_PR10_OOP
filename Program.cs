using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace NomerTri
{

    public class Start
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Start()
        {
            Console.WriteLine("Введите коэфициенты \n");

            Console.WriteLine("Коэффициент A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Коэффициент B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Коэффициент C: \n");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ваши коэффициенты: A = {A}, B = {B}, C = {C}");

        }
    }

    public class Aif
    {
        public void Proccess(Start start)
        {
            if (start.A == 0)
            {
                AIsNull aIsNull = new AIsNull(start);
            }
            else
            {
                AIsNotNull aIsNotNull = new AIsNotNull(start);
            }

        }
    }

    public class AIsNull
    {
        public AIsNull(Start start)
        {
            int A = start.A;
            int B = start.B;
            int C = start.C;

            Console.WriteLine("A is null");

            if (B == 0)
            {
                if (start.C == 0)
                {
                    Console.WriteLine("X - любое число");
                }
                else
                {
                    Console.WriteLine("Нет решщения");
                }
            }
            else
            {
                int X1 = -C / B;
                Console.WriteLine($"X1 = {X1}");
            }
        }
    }

    public class AIsNotNull
    {
        public AIsNotNull(Start start)
        {
            int A = start.A;
            int B = start.B;
            int C = start.C;

            Console.WriteLine("A is not null");

            double D = B * B - 4 * A * C;

            if (D > 0)
            {
                D = Math.Sqrt(D);
                double X1 = (-B - D) / 2 * A;
                double X2 = (-B + D) / 2 * A;
                Console.WriteLine($"X1 = {X1}, X2 = {X2}");
            }
            else
            {
                if (D == 0)
                {
                    double X1 = -B / 2 * A;
                    Console.WriteLine($"X1 = {X1}");
                }
                else
                {
                    Console.WriteLine("Нет решения");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            Aif aif = new Aif();
            aif.Proccess(start);
            Console.WriteLine("Конец");
        }
    }
}
