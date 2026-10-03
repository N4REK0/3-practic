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
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

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
         
        }
    }
}
```
---
