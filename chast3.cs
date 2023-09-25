using System;

namespace ZadWithClass
{
    class chast3
    {
        private double[] array;
        public int count = 0;

        public chast3() // Конструктор без параметров
        {

        }




        public chast3(int size)  // рандом
        {
            double a = 0, b = 0, c = 0;
            Triangle triangle = new Triangle(a, b, c);
            array = new double[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                a = rnd.NextDouble();
                b = rnd.NextDouble();
                c = rnd.NextDouble();

                double area = triangle.S_Tr(a, b, c);

                if (double.IsNaN(area))
                {
                    i--;
                }
                else
                {
                    array[i] = area;
                }

            }
        }

        public chast3(int size, bool userInput) // ввод пользователем
        {
            double a = 0, b = 0, c = 0;
            Triangle tr = new Triangle(a, b, c);
            array = new double[size];

            if (userInput)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Введите a: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Введите b: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Введите c: ");
                    c = double.Parse(Console.ReadLine());
                    array[i] = tr.S_Tr(a, b, c);
                }
            }

        }

        public void ShowArray()
        {
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine("Элемент: " + i + " = " + array[i]);
            }
        }

        public void MiN_S()
        {
            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    array[i] = min;
                }
            }
            Console.WriteLine(min);
        }

    }






}