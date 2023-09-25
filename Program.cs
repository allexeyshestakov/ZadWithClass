using System;

namespace ZadWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите сторону A1: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону B1: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону C1: ");
            double c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите параметры сторон у треугольника," +
                " площадь которого будет найдена с помощью статических методов");
            Console.WriteLine("Введите сторону A2: ");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону B2: ");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону C2: ");
            double c2 = double.Parse(Console.ReadLine());
            Triangle triangle1 = new Triangle(a1, b1, c1);
            Triangle triangle2 = new Triangle(a2, b2, c2);
            triangle1.InfoTr();
            double area1 = triangle1.S_Tr(a1, b1, c1);
            Console.WriteLine("Площадь треугольника1: " + area1);
            triangle2.InfoTr();
            double area2 = triangle2.S_Tr(a2, b2, c2);
            Console.WriteLine("Площадь треугольника2: " + area2);
            double areaStatic = Triangle.S_Tr_Static(a2, b2, c2);
            Console.WriteLine("Площадь, вычисленная с использованием статической функции: " + areaStatic);
            double areaMethod = triangle1.S_Tr_Method();
            Console.WriteLine("Площадь, вычисленная с использованием метода класса: " + areaMethod);
            int objectCount = Triangle.ObjCount();
            Console.WriteLine("Количество созданных объектов класса Triangle: " + objectCount);
            Console.WriteLine("Часть 2:");
            Console.WriteLine("Унарные операции");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Выберите увеличить или уменьшить стороны на 1(введите + или -)");

            if (Console.ReadLine() == "+")
            {
                Triangle Triangle1 = new Triangle(a1, b1, c1);
                Triangle Triangle2 = new Triangle(a2, b2, c2);
                triangle1++;
                triangle1--;


                triangle1++.InfoTr();

                Console.WriteLine("Площадь треугольника1: " + triangle1.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
                triangle2++.InfoTr();

                Console.WriteLine("Площадь треугольника2: " + triangle2.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
            }
            else if ((Console.ReadLine() == "-"))
            {
                Triangle Triangle1 = new Triangle(a1, b1, c1);
                Triangle Triangle2 = new Triangle(a2, b2, c2);
                triangle1++;
                triangle1--;

                triangle1--.InfoTr();
                Console.WriteLine("Площадь треугольника1: " + triangle1.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
                triangle2--.InfoTr();

                Console.WriteLine("Площадь треугольника2: " + triangle2.S_Tr(triangle1.A, triangle1.B, triangle1.C) + "\n");
            }
            Console.WriteLine("Бинарные операции");
            Console.WriteLine("------------------ \n");

            Triangle Triangle11 = new Triangle(a1, b1, c1);
            Triangle Triangle22 = new Triangle(a2, b2, c2);

            if (Triangle11.S_Tr(a1, b1, c1) >= Triangle22.S_Tr(a1, b1, c1))
            {
                Console.WriteLine("Площадь первого треугольника меньше или равна второму");
            }
            else if (Triangle11.S_Tr(a1, b1, c1) <= Triangle22.S_Tr(a1, b1, c1)) Console.WriteLine("Площадь первого треугольника больше или равна второму");

            Console.Clear();



            Console.WriteLine("Часть 3");
            Console.WriteLine("--------------");
            Console.WriteLine("Рандомные значения:");
            Console.WriteLine("Введите количество элементов в массиве");










            chast3 arr1 = new chast3(); // Создание объекта с конструктором без параметров




            Console.WriteLine("Заполнение рандомными элементами:");
            Console.WriteLine("Введите размерность массива с рандомным заполнением");
            chast3 arr2 = new chast3(int.Parse(Console.ReadLine())); // Создание объекта с конструктором с параметром размера
            arr2.ShowArray();


            Console.WriteLine("Заполнение пользователеь:");
            Console.WriteLine("Введите размерность массива с заполнением пользователем");
            chast3 arr3 = new chast3(int.Parse(Console.ReadLine()), true); // Создание объекта с конструктором с пользовательским вводом


            arr3.ShowArray();



            int totalObjects = arr1.count + arr2.count + arr3.count; // Общее количество созданных объектов

            Console.WriteLine("Количество созданных объектов: " + totalObjects);

            Console.WriteLine("Минимальная площадь с рандомными значениями:");
            arr2.MiN_S();
            Console.WriteLine("Минимальная площадь с площадями, где знаячения сторон вводил пользователь:");
            arr3.MiN_S();

            Console.ReadLine();





        }
    }
}
