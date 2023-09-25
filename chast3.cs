using System;

namespace ZadWithClass
{
    class chast3
    {
        private double[] array;
        public static int count = 0;
        // Конструктор без параметров
        public chast3()
        {
            count++;
        }
        public chast3(int size)  // Рандомное заполнение сторон 
        {
            double a = 0, b = 0, c = 0;
            // Создание объекта
            Triangle triangle = new Triangle(a, b, c);
            array = new double[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                // Заполнение сторон дробными числами от 50 до 1
                a = rnd.NextDouble() * (50 - 1) + 1;
                b = rnd.NextDouble() * (50 - 1) + 1;
                c = rnd.NextDouble() * (50 - 1) + 1;
                // Внесение площади в переменную
                double area = triangle.S_Tr(a, b, c);

                // Проверка на "не число"
                if (double.IsNaN(area))
                {
                    i--;
                }
                else
                {
                    array[i] = area;
                }
            }
            // Счетчик создания объекта
            count++;
        }

        // Заполнение сторон пользователем
        public chast3(int size, bool userInput)
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
            count++;
        }

        // Вывод массива 
        public void ShowArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Элемент: " + i + " = " + array[i]);
            }
        }

        // Поиск минимального элемента массива
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

        // Метод для возврата количества созданных объектов
        public int ShowCount()
        {
            return count;
        }
    }
}