using System;

namespace ZadWithClass
{
    internal class Triangle
    {
        // Поля класса
        private static int count = 0;
        private double a;
        private double b;
        private double c;

        // инициализация полей
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

        // Вывод информации о сторонах треугольника
        public void InfoTr()
        {
            Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
        }
        // Поиск площади треугольника по формуле Герона
        public double S_Tr(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        // Статический поиск площади по формуле Герона
        public static double S_Tr_Static(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        // Метод поиска площади треугольника по формуле Герона
        public double S_Tr_Method()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        // Счетчик создания объектов класса
        public static int ObjCount()
        {
            return count;
        }
        // Перегруженный оператор инкремента
        public static Triangle operator ++(Triangle triangle)
        {
            triangle.A++;
            triangle.B++;
            triangle.C++;
            return triangle;
        }
        // Перегруженный оператор декремента
        public static Triangle operator --(Triangle triangle)
        {
            triangle.A--;
            triangle.B--;
            triangle.C--;
            return triangle;
        }
        // Перегруженный оператор >=
        public static bool operator >=(Triangle S1, Triangle S2)
        {
            return S1 >= S2;
        }
        // Перегруженный оператор <=
        public static bool operator <=(Triangle S1, Triangle S2)
        {
            return S1 <= S2;
        }
    }
}
