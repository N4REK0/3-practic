using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_practic__3._3_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 101. Дано целое число. Проверить, принадлежит ли оно числовому отрезку [ 10 ; 50 ] .

            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 10 && number <= 50)
            //{
            //    Console.WriteLine("Число принадлежит отрезку [10; 50]");
            //}
            //else
            //{
            //    Console.WriteLine("Число не принадлежит отрезку [10; 50]");
            //}



            // 102. Проверить, является ли введенное целое число положительным и четным одновременно.

            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number > 0 && number % 2 == 0)
            //{
            //    Console.WriteLine("Введенное целое число является положительным и четным одновременно");
            //}

            //else
            //{
            //    Console.WriteLine("Введенное целое число не является положительным и четным одновременно");
            //}



            // 103. Проверить, лежит ли число вне диапазона [ − 10 ; 10 ] .

            //Console.Write("Введите число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= -10 && number <= 10)
            //{
            //    Console.WriteLine("Число лежит в диапазоне [ -10 ; 10 ]");
            //}

            //else
            //{
            //    Console.WriteLine("Число не лежит в диапазоне [ -10 ; 10 ]");
            //}



            // 104. Ввести логин и пароль пользователя. Вывести «Успех», если логин равен admin и пароль secret.

            //Console.Write("Введите логин: ");
            //string login = (Console.ReadLine());

            //Console.Write("Введите пароль: ");
            //string password = (Console.ReadLine());

            //if (login == "admin" && password == "secret" )
            //{
            //    Console.WriteLine("Успех");
            //}

            //else
            //{
            //    Console.WriteLine("Неверный логин или пароль");
            //}



            // 105. Проверить, является ли введенный год високосным (делится на 4, но не на 100, либо делится на 400).

            //Console.Write("Введите год: ");
            //int year = int.Parse(Console.ReadLine());

            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    Console.WriteLine("Год является високосным");
            //}

            //else
            //{
            //    Console.WriteLine("Год не является високосным");
            //}



            // 106. Даны координаты точки ( X , Y ) . Определить, попадает ли точка в I координатную четверть ( X > 0 и Y > 0 ).

            //Console.Write("Введите координаты точки X: ");
            //decimal X = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите координаты точки Y: ");
            //decimal Y = decimal.Parse(Console.ReadLine());

            //if (X > 0 && Y > 0)
            //{
            //    Console.WriteLine("Точка попадает в I координатную четверть");
            //}

            //else
            //{
            //    Console.WriteLine("Точка попадает в другую координатную четверть");
            //}



            // 107. Определить, попадает ли точка ( X , Y ) во II четверть плоскости.

            //Console.Write("Введите координаты точки X: ");
            //decimal X = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите координаты точки Y: ");
            //decimal Y = decimal.Parse(Console.ReadLine());

            //if (X < 0 && Y > 0)
            //{
            //    Console.WriteLine("Точка попадает в II координатную четверть");
            //}

            //else
            //{
            //    Console.WriteLine("Точка попадает в другую координатную четверть");
            //}



            // 108. Определить, попадает ли точка ( X , Y ) в III четверть плоскости.

            //Console.Write("Введите координаты точки X: ");
            //decimal X = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите координаты точки Y: ");
            //decimal Y = decimal.Parse(Console.ReadLine());

            //if (X < 0 && Y < 0)
            //{
            //    Console.WriteLine("Точка попадает в III координатную четверть");
            //}

            //else
            //{
            //    Console.WriteLine("Точка попадает в другую координатную четверть");
            //}



            // 109. Определить, попадает ли точка ( X , Y ) в IV четверть плоскости.

            //Console.Write("Введите координаты точки X: ");
            //decimal X = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите координаты точки Y: ");
            //decimal Y = decimal.Parse(Console.ReadLine());

            //if (X > 0 && Y < 0)
            //{
            //    Console.WriteLine("Точка попадает в IV координатную четверть");
            //}

            //else
            //{
            //    Console.WriteLine("Точка попадает в другую координатную четверть");
            //}



            // 110. Даны три стороны A , B , C . Проверить, является ли треугольник прямоугольным (теорема Пифагора).

            //Console.Write("Введите катет треугольника (A): ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Введите катет треугольника (B): ");
            //int B = int.Parse(Console.ReadLine());

            //Console.Write("Введите гипотенузу треугольника (C): ");
            //int C = int.Parse(Console.ReadLine());

            //int squareA = A * A;
            //int squareB = B * B;
            //int squareC = C * C;

            //if (squareA + squareB == squareC)
            //{
            //    Console.WriteLine("Треугольник прямоугольный");
            //}

            //else
            //{
            //    Console.WriteLine("Треугольник не прямоугольный");
            //}



            // 111. Даны три стороны. Проверить, является ли треугольник равнобедренным.

            //Console.Write("Введите первую сторону треугольника (A): ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Введите вторую сторону треугольника (B): ");
            //int B = int.Parse(Console.ReadLine());

            //Console.Write("Введите основание треугольника (C): ");
            //int C = int.Parse(Console.ReadLine());

            //if (A == B)
            //{
            //    Console.WriteLine("Треугольник равнобедренный");
            //}

            //else
            //{
            //    Console.WriteLine("Треугольник не равнобедренный");
            //}



            // 112. Ввести возраст и стаж вождения. Разрешить аренду каршеринга бизнес-класса, если возраст ≥ 23 лет И стаж ≥ 3 лет.

            //Console.Write("Введите возраст автомобилиста: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Введите стаж вождения: ");
            //int exp = int.Parse(Console.ReadLine());

            //if (age >= 23 && exp >= 3)
            //{
            //    Console.WriteLine("Вам одобрена аренда каршеринга бизнес-класса");
            //}

            //else
            //{
            //    Console.WriteLine("Вам не одобрена аренда каршеринга бизнес-класса");
            //}



            // 113. Проверить, делится ли число одновременно на 3 и на 5 без остатка.

            //Console.Write("Введите число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 3 == 0 && number % 5 == 0)
            //{
            //    Console.WriteLine("Делится");
            //}

            //else
            //{
            //    Console.WriteLine("Не елится");
            //}



            // 114. Проверить, является ли число трехзначным и оканчивается ли оно на цифру 5.

            //Console.Write("Введите число: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number >= 100 && number <= 999 && number % 5 == 0 && number % 10 != 0 )
            //{
            //    Console.WriteLine("Число является трехзначным и оканчивается на цифру 5");
            //}

            //else
            //{
            //    Console.WriteLine("Число не является трехзначным или не оканчивается на цифру 5");
            //}



            // 115. Даны три числа. Проверить, упорядочены ли они строго по возрастанию ( A < B < C ).

            //Console.Write("Введите первое число: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.Write("Введите третье число: ");
            //int number3 = int.Parse(Console.ReadLine());

            //int temp;

            //if (number1 > number2)
            //{
            //    temp = number1;
            //    number1 = number2;
            //    number2 = temp;
            //}

            //if (number1 > number3)
            //{
            //    temp = number1;
            //    number1 = number3;
            //    number3 = temp;
            //}

            //if (number2 > number3)
            //{
            //    temp = number2;
            //    number2 = number3;
            //    number3 = temp;
            //}

            //Console.WriteLine($"{number1} {number2} {number3}");



            // 116. Проверить, верно ли, что среди трех введенных чисел есть хотя бы одно четное.

            //Console.Write("Введите первое число: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.Write("Введите третье число: ");
            //int number3 = int.Parse(Console.ReadLine());

            //if (number1 % 2 == 0 || number2 % 2 == 0 || number3 % 2 == 0)
            //{
            //    Console.WriteLine("Cреди трех введенных чисел есть хотя бы одно четное");
            //}

            //else
            //{
            //    Console.WriteLine("Cреди трех введенных чисел нет четных чисел");
            //}



            // 117. Проверить, верно ли, что среди трех чисел ровно одно равно нулю.

            //Console.Write("Введите первое число: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Введите второе число: ");
            //int number2 = int.Parse(Console.ReadLine());

            //Console.Write("Введите третье число: ");
            //int number3 = int.Parse(Console.ReadLine());

            //int zero = 0;

            //if (number1 == 0)
            //{
            //    zero++;
            //}

            //if (number2 == 0)
            //{
            //    zero++;
            //}

            //if (number3 == 0)
            //{
            //    zero++;
            //}

            //if (zero == 1)
            //{
            //    Console.WriteLine("Cреди трех чисел ровно одно равно нулю");
            //}

            //else
            //{
            //    Console.WriteLine("Cреди трех чисел либо нулей нет, либо их больше чем один");
            //}



            // 118. Ввести температуру и влажность. Вывести предупреждение о гололедице, если температура ≤ 0 ∘C И влажность > 85 .

            //Console.Write("Введите температуру: ");
            //int t = int.Parse(Console.ReadLine());

            //Console.Write("Введите влажность: ");
            //int vlajnost = int.Parse(Console.ReadLine());

            //if (t <= 0 && vlajnost > 85)
            //{
            //    Console.WriteLine("Осторожно! Гололедица");
            //}

            //else
            //{
            //    Console.WriteLine("");
            //}



            // 119. Даны координаты точки ( X , Y ) . Проверить, лежит ли точка внутри круга радиуса R с центром в начале координат ( x 2 + y 2 ≤ R 2 ).

            //Console.Write("Введите значение X: ");
            //int X = int.Parse(Console.ReadLine());

            //Console.Write("Введите значение Y: ");
            //int Y = int.Parse(Console.ReadLine());

            //Console.Write("Введите значение r: ");
            //int r = int.Parse(Console.ReadLine());

            //if (X * X + Y * Y <= r * r)
            //{
            //    Console.WriteLine("Точка лежит внутри круга радиуса R");
            //}

            //else
            //{
            //    Console.WriteLine("Точка не лежит внутри круга");
            //}



            // 120. Даны координаты точки ( X , Y ) . Проверить, лежит ли точка внутри прямоугольника со сторонами, параллельными осям, заданного углами ( X 1 , Y 1 ) и ( X 2 , Y 2 ) .

            // Координаты точек X и Y
            //Console.Write("Введите значение x: ");
            //decimal x = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите значение y: ");
            //decimal y = decimal.Parse(Console.ReadLine());

            //// Координаты первого угла прямоугольника
            //Console.Write("Введите значение X1: ");
            //decimal X1 = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите значение Y1: ");
            //decimal Y1 = decimal.Parse(Console.ReadLine());

            //// Координаты второго угла прямоугольника
            //Console.Write("Введите значение X2: ");
            //decimal X2 = decimal.Parse(Console.ReadLine());

            //Console.Write("Введите значение Y2: ");
            //decimal Y2 = decimal.Parse(Console.ReadLine());

            //// Находим границы прямоугольника 
            //decimal minX = Math.Min(X1, X2);
            //decimal maxX = Math.Max(X1, X2);

            //decimal minY = Math.Min(Y1, Y2);
            //decimal maxY = Math.Max(Y1, Y2);


            //// Проверяем, находится ли точка внутри
            //if (x >= minX && x <= maxX && y >= minY && y <= maxY)
            //{
            //    Console.WriteLine("Лежит");
            //}

            //else
            //{
            //    Console.WriteLine("Не лежит");
            //}



            // 121. Ввести день и месяц рождения. Проверить, корректна ли дата (например, день от 1 до 31, месяц от 1 до 12, с учетом длины месяцев).

            //Console.Write("Введите день рождения: ");
            //int den = int.Parse(Console.ReadLine());

            //Console.Write("Введите месяц рождения: ");
            //int mes = int.Parse(Console.ReadLine());

            //if (den >= 1 && den <= 31 && mes >= 1 && mes <= 12)
            //{
            //    Console.WriteLine("Корректно");
            //}

            //else
            //{
            //    Console.WriteLine("Некорректно");
            //}



            // 122. Ввести номер месяца. Проверить, относится ли он к зимнему периоду (12, 1 или 2).

            //Console.Write("Введите месяц: ");
            //int mes = int.Parse(Console.ReadLine());

            //if (mes == 12 || mes == 1 || mes == 2)
            //{
            //    Console.WriteLine("Месяц отсносится к зимнему периоду");
            //}

            //else
            //{
            //    Console.WriteLine("Не относится");
            //}



            // 123. Проверить, является ли четырехзначное число «счастливым билетом» (сумма первых двух цифр равна сумме двух последних).

            //Console.Write("Введите номер билета: ");
            //int ticket = int.Parse(Console.ReadLine());

            //if (ticket  )





        }
    }
}
