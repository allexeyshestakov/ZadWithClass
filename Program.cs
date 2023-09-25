using System;

namespace ZadWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ввод значений

            Console.WriteLine("Введите сторону A1: ");
            double a1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону B1: ");
            double b1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону C1: ");
            double c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите размеры сторон у треугольника," +
                " площадь которого будет найдена с помощью статических методов");

            Console.WriteLine("Введите сторону A2: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону B2: ");
            double b2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону C2: ");
            double c2 = double.Parse(Console.ReadLine());

            // Создание объектов

            Triangle triangle1 = new Triangle(a1, b1, c1);
            Triangle triangle2 = new Triangle(a2, b2, c2);

            // Информация о сторонах треугольника и вывод площади треугольника
            triangle1.InfoTr();
            double area1 = triangle1.S_Tr(a1, b1, c1);
            Console.WriteLine("Площадь треугольника1: " + area1);

            // Информация о сторонах треугольника и вывод площади треугольника
            triangle2.InfoTr();
            double area2 = triangle2.S_Tr(a2, b2, c2);
            Console.WriteLine("Площадь треугольника2: " + area2);

            // Площади с использованием статических и обычных функций
            double areaStatic = Triangle.S_Tr_Static(a2, b2, c2);
            Console.WriteLine("Площадь, вычисленная с использованием статической функции: " + areaStatic);
            double areaMethod = triangle1.S_Tr_Method();
            Console.WriteLine("Площадь, вычисленная с использованием метода класса: " + areaMethod);

            // Количество созданных объектов класса
            int objectCount = Triangle.ObjCount();
            Console.WriteLine("Количество созданных объектов класса Triangle: " + objectCount);

            // Часть 2
            Console.WriteLine("Часть 2:");
            Console.WriteLine("Унарные операции");
            Console.WriteLine("----------------");
            Console.WriteLine("Выберите увеличить или уменьшить стороны на 1(введите + или -)");

            if (Console.ReadLine() == "+")
            {
                // перегруженный оператор инкермента
                triangle1++;

                // Вывод и вычисление площади
                triangle1++.InfoTr();
                Console.WriteLine("Площадь треугольника1: " + triangle1.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
                triangle2++.InfoTr();
                Console.WriteLine("Площадь треугольника2: " + triangle2.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
            }
            else if ((Console.ReadLine() == "-"))
            {
                // перегруженный оператор инкермента
                triangle1--;

                // Вывод и вычисление площади
                triangle1--.InfoTr();
                Console.WriteLine("Площадь треугольника1: " + triangle1.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
                triangle2--.InfoTr();
                Console.WriteLine("Площадь треугольника2: " + triangle2.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
            }

            Console.WriteLine("Бинарные операции");
            Console.WriteLine("-----------------");

            // Создание объектов
            Triangle Triangle11 = new Triangle(a1, b1, c1);
            Triangle Triangle22 = new Triangle(a2, b2, c2);

            // Использование перегруженного оператора >= и <= 
            if (Triangle11.S_Tr(a1, b1, c1) >= Triangle22.S_Tr(a1, b1, c1))
            {
                Console.WriteLine("Площадь первого треугольника меньше или равна второму");
            }
            else if (Triangle11.S_Tr(a1, b1, c1) <= Triangle22.S_Tr(a1, b1, c1))
            {
                Console.WriteLine("Площадь первого треугольника больше или равна второму");
            }

            // Часть 3
            Console.WriteLine("Часть 3");
            Console.WriteLine("--------------");

            // Создание объекта с конструктором без параметров
            chast3 arr1 = new chast3();
            Console.WriteLine("Заполнение рандомными площадями:");
            Console.WriteLine("Введите размерность массива с рандомным заполнением");

            // Создание объекта с конструктором с параметром размера
            chast3 arr2 = new chast3(int.Parse(Console.ReadLine()));
            arr2.ShowArray();

            Console.WriteLine("Заполнение сторон пользователем:");
            Console.WriteLine("Введите размерность массива с заполнением пользователем");
            // Создание объекта с конструктором с пользовательским вводом
            chast3 arr3 = new chast3(int.Parse(Console.ReadLine()), true);
            arr3.ShowArray();

            // Общее количество созданных объектов
            int totalObjects = arr2.ShowCount() + arr3.ShowCount() + arr1.ShowCount();
            Console.WriteLine("Количество созданных объектов: " + totalObjects);

            // Минимальные значения в массивах рандомном и пользовательском
            Console.WriteLine("Минимальная площадь с рандомными значениями:");
            arr2.MiN_S();
            Console.WriteLine("Минимальная площадь с площадями, где знаячения сторон вводил пользователь:");
            arr3.MiN_S();

            // Чтобы консоль не закрывалась
            Console.ReadLine();
        }
    }
}
