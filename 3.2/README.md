# Практическая работа №3
## Выполнил студент группы П25-2.1. Оганджанян Нарек Артёмикович

### Раздел 2. Множественные ветвления else if и диапазоны
---
№ 51. Ввести балл за тест(0–100).Вывести оценку по шкале ECTS: A(90 - 100), B(80 - 89), C(70 - 79), D(60 - 69), F(менее 60).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите баллы за тест (0-100): ");
            int mark = int.Parse(Console.ReadLine());

            if (mark >= 90 && mark <= 100)
            {
                Console.WriteLine("Оценка: A");
            }

            else if (mark >= 80 && mark <= 89)
            {
                Console.WriteLine("Оценка: B");
            }

            else if (mark >= 70 && mark <= 79)
            {
                Console.WriteLine("Оценка: C");
            }

            else if (mark >= 60 && mark <= 69)
            {
                Console.WriteLine("Оценка: D");
            }

            else if (mark < 60)
            {
                Console.WriteLine("Оценка: F");
            }
        }
    }
}
```
---
№ 52. Ввести возраст человека. Определить категорию: ребенок (0-12), подросток (13-17), взрослый (18-64), пожилой (65+).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите возраст человека: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 0 && age <= 12)
            {
                Console.WriteLine("Ребенок");
            }

            else if (age >= 13 && age <= 17)
            {
                Console.WriteLine("Подросток");
            }

            else if (age >= 18 && age <= 64)
            {
                Console.WriteLine("Взрослый");
            }

            else if (age >= 65)
            {
                Console.WriteLine("Пожилой");
            }
        }
    }
}
```
---
№ 53. Ввести температуру воды. Вывести ее агрегатное состояние: «Лед» ( ≤ 0 ), «Жидкость» ( 0 < t < 100 ), «Пар» ( ≥ 100 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите температуру воды: ");
            int t = int.Parse(Console.ReadLine());

            if (t == 0)
            {
                Console.WriteLine("Лед");
            }

            else if (t > 0 && t < 100)
            {
                Console.WriteLine("Жидкость");
            }

            else if (t >= 100)
            {
                Console.WriteLine("Пар");
            }
        }
    }
}
```
---
№ 54. Ввести уровень заряда аккумулятора смартфона (в %). Вывести: «Критический» ( < 10 ), «Низкий» (10-20), «Нормальный» (21-80), «Полный» (81-100).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите уровень заряда аккумулятора: ");
            int zaryad = int.Parse(Console.ReadLine());

            if (zaryad < 10)
            {
                Console.WriteLine("Критический");
            }

            else if (zaryad >= 10 && zaryad <= 20)
            {
                Console.WriteLine("Низкий");
            }

            else if (zaryad >= 21 && zaryad <= 80)
            {
                Console.WriteLine("Нормальный");
            }

            else if (zaryad >= 81 && zaryad <= 100)
            {
                Console.WriteLine("Полный");
            }
        }
    }
}
```
---
№ 55. Ввести число оборотов двигателя в минуту (RPM). Вывести режим: «Заглушен» (0), «Холостой ход» (1-900), «Рабочий» (901-3500), «Красная зона» (3501+).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число оборотов в минуту: ");
            int RPM = int.Parse(Console.ReadLine());

            if (RPM == 0)
            {
                Console.WriteLine("Заглушен");
            }

            else if (RPM >= 1 && RPM <= 900)
            {
                Console.WriteLine("Холостой ход");
            }

            else if (RPM >= 901 && RPM <= 3500)
            {
                Console.WriteLine("Рабочий");
            }

            else if (RPM >= 3501)
            {
                Console.WriteLine("Красная зона");
            }
        }
    }
}
```
---
№ 56. Ввести сумму дохода за год. Рассчитать подоходный налог: до 2.4 млн — 13%, до 5 млн — 15%, выше 5 млн — 18%.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите сумму дохода за год: ");
            decimal money = decimal.Parse(Console.ReadLine());

            int percent13 = 13;
            int percent15 = 15;
            int percent18 = 18;

            if (money <= 2400000m)
            {
                Console.WriteLine($"Подоходный налог составит 13%. К оплате: {(money * percent13) / 100}");
            }

            else if (money > 2400000 && money <= 5000000)
            {
                Console.WriteLine($"Подоходный налог составит 15%. К оплате: {(money * percent15) / 100}");
            }

            else if (money > 5000000)
            {
                Console.WriteLine($"Подоходный налог составит 18%. К оплате: {(money * percent18) / 100}");
            }
        }
    }
}
```
---
№ 57. По введенной координате X точки на плоскости (при Y = 0 ) определить ее положение: на нуле, в положительной или отрицательной полуоси.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите координату точки X: ");
            int X = int.Parse(Console.ReadLine());

            if (X == 0)
            {
                Console.WriteLine("Точка X лежит на нуле");
            }

            else if (X > 0)
            {
                Console.WriteLine("Точка X лежит на положительной полуоси");
            }

            else if (X < 0)
            {
                Console.WriteLine("Точка X лежит на отрицательной полуоси");
            }
        }
    }
}
```
---
№ 58. Ввести индекс массы тела (ИМТ). Вывести категорию: дефицит веса ( < 18.5 ), норма (18.5-24.9), избыток (25-29.9), ожирение ( 30 + ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите индекс массы тела (ИМТ): ");
            decimal imt = decimal.Parse(Console.ReadLine());

            if (imt < 18.5m)
            {
                Console.WriteLine("Дефицит веса");
            }

            else if (imt >= 18.5m && imt <= 24.9m)
            {
                Console.WriteLine("Норма");
            }

            else if (imt >= 25 && imt < 29.9m)
            {
                Console.WriteLine("Избыток");
            }

            else if (imt > 30)
            {
                Console.WriteLine("Ожирение");
            }
        }
    }
}
```
---
№ 59. Ввести скорость ветра (м/с). Вывести категорию по шкале: штиль ( < 0.2 ), легкий ветерок (0.2-5), умеренный (5.1-14), шторм (14.1-24), ураган ( > 24 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    Console.Write("Введите скорость ветра: ");
            decimal v = decimal.Parse(Console.ReadLine());

            if (v < 0.2m)
            {
                Console.WriteLine("Штиль");
            }

            else if (v >= 0.2m && v <= 5)
            {
                Console.WriteLine("Легкий ветерок");
            }

            else if (v >= 5.1m && v <= 14)
            {
                Console.WriteLine("Умеренный");
            }

            else if (v >= 14.1m && v < 24)
            {
                Console.WriteLine("Шторм");
            }

            else if (v >= 24)
            {
                Console.WriteLine("Ураган");
            }
        }
    }
}
```
---
№ 60. Ввести стаж работы сотрудника (в годах). Вывести размер надбавки: < 1 года — 0%, 1-5 лет — 5%, 6-10 лет — 10%, > 10 лет — 15%.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    Console.Write("Введите стаж работы сотрудника в годах: ");
            int year = int.Parse(Console.ReadLine());

            if (year < 1)
            {
                Console.WriteLine("Надбавка 0%");
            }

            else if (year >= 1 && year <= 5)
            {
                Console.WriteLine("Надбавка 5%");
            }

            else if (year >= 6 && year <= 10)
            {
                Console.WriteLine("Надбавка 10%");
            }

            else if (year > 10)
            {
                Console.WriteLine("Надбавка 15%");
            }
        }
    }
}
```
---
№ 61. Пользователь вводит текущий час (0–23). Вывести: «Ночь» (0-5), «Утро» (6-11), «День» (12-17), «Вечер» (18-23).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текущий час (0-23): ");
            int hour = int.Parse(Console.ReadLine());

            if (hour >= 0 && hour <= 5)
            {
                Console.WriteLine("Ночь");
            }

            else if (hour >= 6 && hour <= 11)
            {
                Console.WriteLine("Утро");
            }

            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("День");
            }

            else if (hour >= 18 && hour <= 23)
            {
                Console.WriteLine("Вечер");
            }
        }
    }
}
```
---
№ 62. Ввести толщину льда на водоеме (см). Вывести: «Выход запрещен» ( < 7 ), «Одиночный пешеход» (7-12), «Группа людей» (13-20), «Транспорт» ( > 20 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите толщину льда на водоеме (см): ");
            int ice = int.Parse(Console.ReadLine());

            if (ice < 7)
            {
                Console.WriteLine("Вход запрещен");
            }

            else if (ice >= 7 && ice <=12)
            {
                Console.WriteLine("Одиночный пешеход");
            }

            else if (ice >= 13 && ice <= 20)
            {
                Console.WriteLine("Группа людей");
            }

            else if (ice > 20)
            {
                Console.WriteLine("транспорт");
            }
        }
    }
}
```
---
№ 63. Даны три целых числа A , B , C . Найти максимальное из них, используя каскадное условие.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите третье целое число: ");
            int C = int.Parse(Console.ReadLine());

            if (A >= B && A >= C)
            {
                Console.WriteLine($"max: {A}");
            }

            else if (B >= A && B >= C)
            {
                Console.WriteLine($"max: {B}");
            }

            else
            {
                Console.WriteLine($"max: {C}");
            }
        }
    }
}
```
---
№ 64. Даны три числа. Найти минимальное из них.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите первое целое число: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int Y = int.Parse(Console.ReadLine());

            Console.Write("Введите третье целое число: ");
            int Z = int.Parse(Console.ReadLine());

            if (X <= Y && X < Z)
            {
                Console.WriteLine($"min: {X}");
            }

            else if (Y <= X && Y <= Z)
            {
                Console.WriteLine($"min: {Y}");
            }

            else
            {
                Console.WriteLine($"min: {Z}");
            }
        }
    }
}
```
---
№ 65. Даны три числа. Определить, сколько из них положительных (0, 1, 2 или 3).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое целое число: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите второе целое число: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите третье целое число: ");
            int C = int.Parse(Console.ReadLine());

            int score = 0;

            if (A > 0)
            {
                score++;
            }

            if (B > 0)
            {
                score++;
            }

            if (C > 0)
            {
                score++;
            }

            Console.WriteLine($"Количество положительных чисел: {score}");
        }
    }
}
```
---
№ 66. Ввести средний балл диплома. Вывести: «Без отличия» ( < 4.5 ), «Претендент на красный диплом» (4.5-4.74), «Красный диплом» ( ≥ 4.75 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите средный балл диплома: ");
            decimal ball = decimal.Parse(Console.ReadLine());

            if (ball < 4.5m)
            {
                Console.WriteLine("Без отличия");
            }

            else if (ball >= 4.5m && ball <= 4.74m)
            {
                Console.WriteLine("Претендент на красный диплом");
            }

            else if (ball >= 4.75m)
            {
                Console.WriteLine("Красный диплом");
            }
        }
    }
}
```
---
№ 67. Ввести значение артериального давления (систолическое). Вывести: гипотония ( < 90 ), норма (90-120), предгипертензия (121-139), гипертензия ( ≥ 140 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите значение артериального давления: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 90)
            {
                Console.WriteLine("Гипотония");
            }

            else if (number >= 90 && number <= 120)
            {
                Console.WriteLine("Норма");
            }

            else if (number >= 121 && number <= 139)
            {
                Console.WriteLine("Предгипертензия");
            }

            else if (number >= 140)
            {
                Console.WriteLine("Гипертензия");
            }
        }
    }
}
```
---
№ 68. Ввести рейтинг шахматиста (Эло). Вывести ранг: любитель ( < 1400 ), разрядник (1400-1999), мастер (2000-2399), гроссмейстер ( ≥ 2400 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите значение артериального давления: ");
            int elo = int.Parse(Console.ReadLine());

            if (elo < 1400)
            {
                Console.WriteLine("Любитель");
            }

            else if (elo >= 1400 && elo <= 1999)
            {
                Console.WriteLine("Разрядник");
            }

            else if (elo >= 2000 && elo <= 2399)
            {
                Console.WriteLine("Мастер");
            }

            else if (elo >= 2400)
            {
                Console.WriteLine("Гроссмейстер");
            }
        }
    }
}
```
---
№ 69. Ввести число и определить, сколькизначным оно является (однозначное, двузначное, трехзначное или более).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number >=0 && number <=9)
            {
                Console.WriteLine("Число однозначное");
            }

            else if (number >= 10 && number <= 99)
            {
                Console.WriteLine("Число двузначное");
            }

            else if (number >= 100 && number <= 999)
            {
                Console.WriteLine("Число Трехзначное");
            }

            else
            {
                Console.WriteLine("другое");
            }
        }
    }
}
```
---
№ 70. Ввести дальность поездки на такси (км). Рассчитать тариф: до 5 км — 200 руб, от 5 до 15 км — 200 + 25 руб/км, свыше 15 км — 200 + 20 руб/км.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Ввести дальность поездки на такси: ");
            int km = int.Parse(Console.ReadLine());

            if (km <= 5)
            {
                Console.WriteLine("Сумма поездки: 200 рублей");
            }

            else if (km >= 5 && km <=15)
            {
                Console.WriteLine($"Сумма поездки: {200 + (km - 5) * 25} рублей");
            }

            else if (km > 15)
            {
                Console.WriteLine($"Сумма поездки: {200 + (15 - 5) * 25 + (km - 15) * 20} рублей");
            }
        }
    }
}
```
---
№ 71. Ввести количество осадков за сутки (мм). Определить: без осадков (0), слабый дождь (0.1-4), умеренный (4.1-15), сильный ливень ( > 15 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите количество осадков за сутки: ");
            decimal mm = decimal.Parse(Console.ReadLine());

            if (mm == 0)
            {
                Console.WriteLine("Без осадков");
            }

            else if (mm >= 0.1m && mm <=4)
            {
                Console.WriteLine("Слабый дождь");
            }

            else if (mm >= 4.1m && mm <= 15)
            {
                Console.WriteLine("Умеренный");
            }

            else if (mm > 15)
            {
                Console.WriteLine("Сильный Ливень");
            }
        }
    }
}
```
---
№ 72. Ввести процент выполнения плана продаж. Вывести статус: план сорван ( < 70 ), удовлетворительно (70-99%), выполнен (100-119%), перевыполнен ( ≥ 120 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите процент выполнения плана продаж: ");
            int plan = int.Parse(Console.ReadLine());

            if (plan < 70)
            {
                Console.WriteLine("План сорван");
            }

            else if (plan >= 70 && plan <= 99)
            {
                Console.WriteLine("Удовлетворительно");
            }

            else if (plan >= 100 && plan <= 119)
            {
                Console.WriteLine("Выполнен");
            }

            else if (plan >= 120)
            {
                Console.WriteLine("Перевыполнен");
            }
        }
    }
}
```
---
№ 73. Даны три числа. Упорядочить их по возрастанию и вывести на консоль.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите первое число: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            int C = int.Parse(Console.ReadLine());

            if (A > B)
            {
                int temp = A;
                A = B;
                B = temp;
            }

            if (A > C)
            {
                int temp = A;
                A = C;
                C = temp;
            }

            if (B > C)
            {
                int temp = B;
                B = C;
                C = temp;
            }

            Console.WriteLine($"{A} {B} {C}");
        }
    }
}
```
---
№ 74. Дано число X . Вычислить значение кусочно-заданной функции: f ( x ) = x 2 , если x > 0 ; f ( x ) = 0 , если x = 0 ; f ( x ) = − x , если x < 0 .

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите число: ");
            int X = int.Parse(Console.ReadLine());

            int f;

            if (X > 0)
            {
                f = X * X;
            }

            else if (X == 0)
            {
                f = 0;
            }

            else 
            {
                f = -X;
            }

            Console.WriteLine($"f(x) = {f}");
        }
    }
}
```
---
№ 75. Ввести октановое число бензина. Классифицировать: < 92 — несоответствие стандарту, 92 — АИ-92, 95 — АИ-95, 98-100 — АИ-98/100, > 100 — спорт/авиатопливо.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите октановое число бензина: ");
            int okt = int.Parse(Console.ReadLine());

            if (okt < 92)
            {
                Console.WriteLine("Несоответствие стандарту");
            }

            else if (okt == 92)
            {
                Console.WriteLine("АИ-92");
            }

            else if (okt == 95)
            {
                Console.WriteLine("АИ-95");
            }

            else if (okt == 98 && okt == 100)
            {
                Console.WriteLine("АИ-98/100");
            }

            else if (okt > 100)
            {
                Console.WriteLine("Спорт/Авиатопливо");
            }
        }
    }
}
```
---
№ 76. Ввести сумму покупок за месяц для начисления кешбэка: до 10 000 руб — 1%, до 50 000 руб — 3%, свыше 50 000 руб — 5%. Вывести сумму кешбэка.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите сумму покупок за месяц для начисления кешбэка: ");
            decimal cb = decimal.Parse(Console.ReadLine());

            if (cb < 10000)
            {
                Console.WriteLine($"Кешбек 1%: {cb * 1 / 100}");
            }

            else if (cb >= 10000 && cb <= 50000)
            {
                Console.WriteLine($"Кешбек 3%: {cb * 3 / 100}");
            }

            else if (cb > 50000)
            {
                Console.WriteLine($"Кешбек 5%: {cb * 5 / 100}");
            }
        }
    }
}
```
---
№ 77. Ввести глубину погружения аквалангиста (метры). Вывести зону: рекреационная ( < 40 ), техническая (40-100), глубоководная ( > 100 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите глубину погружения аквалангиста: ");
            int m = int.Parse(Console.ReadLine());

            if (m < 40)
            {
                Console.WriteLine("Рекреационная");
            }

            else if (m >= 40 && m <= 100)
            {
                Console.WriteLine("Техническая");
            }

            else if (m >= 100)
            {
                Console.WriteLine("Глубоководная");
            }
        }
    }
}
```
---
№ 78. Ввести количество штрафных баллов водителя. Вывести: «Предупреждение» (1-5), «Временное ограничение» (6-10), «Лишение прав» ( > 10 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите количество штрафных баллов водителя: ");
            int straf = int.Parse(Console.ReadLine());

            if (straf >= 1 && straf <= 5)
            {
                Console.WriteLine("Предупреждение");
            }

            else if (straf >= 6 && straf <= 10)
            {
                Console.WriteLine("Предупреждение");
            }

            else if (straf > 10)
            {
                Console.WriteLine("Предупреждение");
            }
        }
    }
}
```
---
№ 79. Ввести уровень кислотности почвы (pH). Определить: кислая ( < 6.0 ), нейтральная (6.0-7.2), щелочная ( > 7.2 ).

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите уровень кислотности почвы: ");
            decimal pH= decimal.Parse(Console.ReadLine());

            if (pH < 6.0m)
            {
                Console.WriteLine("Кислая");
            }

            else if (pH >= 6.0m && pH <= 7.2m)
            {
                Console.WriteLine("Нейтральная");
            }

            else if (pH > 7.2m)
            {
                Console.WriteLine("Щелочная");
            }
        }
    }
}
```
---
№ 80. Ввести количество набранных очков в компьютерной игре. Присвоить медаль: Бронзовая (1000-2499), Серебряная (2500-4999), Золотая (5000+), иначе без медали.

<picture> <img src="скрины 3.2/51.png"> 
</picture>

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     Console.Write("Введите количество набранных очков в компьютерной игре: ");
            int point = int.Parse(Console.ReadLine());

            if (point >= 1000 && point <= 2499)
            {
                Console.WriteLine("Бронзовая медаль");
            }

            else if (point >= 2500 && point <= 4999)
            {
                Console.WriteLine("Серебрянная медаль");
            }

            else if (point >= 5000)
            {
                Console.WriteLine("Золотая медаль");
            }

            else
            {
                Console.WriteLine("Без медали");
            }
        }
    }
}
```
---
