using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadWithClass
{
    internal class Triangle
    {
        private static int count = 0;
        private double a;
        private double b;
        private double c;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public double C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle(double a, double b, double c)
        {
            count++;
            this.a = a;
            this.b = b;
            this.c = c;
        }



        public void InfoTr()
        {
            Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
        }

        public double S_Tr(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public static double S_Tr_Static(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double S_Tr_Method()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public static int ObjCount()
        {
            return count;
        }

        public static Triangle operator ++(Triangle triangle)
        {
            triangle.A++;
            triangle.B++;
            triangle.C++;
            return triangle;
        }

        public static Triangle operator --(Triangle triangle)
        {
            triangle.A--;
            triangle.B--;
            triangle.C--;
            return triangle;
        }

        public static bool operator >=(Triangle S1, Triangle S2)
        {
            return S1 >= S2;
        }
        public static bool operator <=(Triangle S1, Triangle S2)
        {
            return S1 <= S2;
        }









    }
}
