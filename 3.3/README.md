# Практическая работа №3
## Выполнил студент группы П25-2.1. Оганджанян Нарек Артёмикович

### Раздел 2. Множественные ветвления else if и диапазоны
---
№ 101. Дано целое число. Проверить, принадлежит ли оно числовому отрезку [ 10 ; 50 ] .

<picture> <img src="скрины 3.3/101.png"> 
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
№ 102. 

<picture> <img src="скрины 3.3/102.png"> 
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
№ 103. 

<picture> <img src="скрины 3.3/103.png"> 
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
№ 104. Ввести логин и пароль пользователя. Вывести «Успех», если логин равен admin и пароль secret.

<picture> <img src="скрины 3.3/104.png"> 
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
            Console.Write("Введите логин: ");
            string login = (Console.ReadLine());

            Console.Write("Введите пароль: ");
            string password = (Console.ReadLine());

            if (login == "admin" && password == "secret" )
            {
                Console.WriteLine("Успех");
            }

            else
            {
                Console.WriteLine("Неверный логин или пароль");
            }
        }
    }
}
```
---
№ 105. Проверить, является ли введенный год високосным (делится на 4, но не на 100, либо делится на 400).

<picture> <img src="скрины 3.3/105.png"> 
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
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Год является високосным");
            }

            else
            {
                Console.WriteLine("Год не является високосным");
            }
        }
    }
}
```
---
№ 106. Даны координаты точки ( X , Y ) . Определить, попадает ли точка в I координатную четверть ( X > 0 и Y > 0 ).

<picture> <img src="скрины 3.3/106.png"> 
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
            Console.Write("Введите координаты точки X: ");
            decimal X = decimal.Parse(Console.ReadLine());

            Console.Write("Введите координаты точки Y: ");
            decimal Y = decimal.Parse(Console.ReadLine());

            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Точка попадает в I координатную четверть");
            }

            else
            {
                Console.WriteLine("Точка попадает в другую координатную четверть");
            }
        }
    }
}
```
---
№ 107. Определить, попадает ли точка ( X , Y ) во II четверть плоскости.

<picture> <img src="скрины 3.3/107.png"> 
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
            Console.Write("Введите координаты точки X: ");
            decimal X = decimal.Parse(Console.ReadLine());

            Console.Write("Введите координаты точки Y: ");
            decimal Y = decimal.Parse(Console.ReadLine());

            if (X < 0 && Y > 0)
            {
                Console.WriteLine("Точка попадает в II координатную четверть");
            }

            else
            {
                Console.WriteLine("Точка попадает в другую координатную четверть");
            }
        }
    }
}
```
---
№ 108. Определить, попадает ли точка ( X , Y ) в III четверть плоскости.

<picture> <img src="скрины 3.3/108.png"> 
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
            Console.Write("Введите координаты точки X: ");
            decimal X = decimal.Parse(Console.ReadLine());

            Console.Write("Введите координаты точки Y: ");
            decimal Y = decimal.Parse(Console.ReadLine());

            if (X < 0 && Y < 0)
            {
                Console.WriteLine("Точка попадает в III координатную четверть");
            }

            else
            {
                Console.WriteLine("Точка попадает в другую координатную четверть");
            }
        }
    }
}
```
---
№ 109. 

<picture> <img src="скрины 3.3/109.png"> 
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
            Console.Write("Введите координаты точки X: ");
            decimal X = decimal.Parse(Console.ReadLine());

            Console.Write("Введите координаты точки Y: ");
            decimal Y = decimal.Parse(Console.ReadLine());

            if (X > 0 && Y < 0)
            {
                Console.WriteLine("Точка попадает в IV координатную четверть");
            }

            else
            {
                Console.WriteLine("Точка попадает в другую координатную четверть");
            }
        }
    }
}
```
---
№ 110. Даны три стороны A , B , C . Проверить, является ли треугольник прямоугольным (теорема Пифагора).

<picture> <img src="скрины 3.3/110.png"> 
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
            Console.Write("Введите катет треугольника (A): ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите катет треугольника (B): ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите гипотенузу треугольника (C): ");
            int C = int.Parse(Console.ReadLine());

            int squareA = A * A;
            int squareB = B * B;
            int squareC = C * C;

            if (squareA + squareB == squareC)
            {
                Console.WriteLine("Треугольник прямоугольный");
            }

            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
            }
        }
    }
}
```
---
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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
№ 101. 

<picture> <img src="скрины 3.3/101.png"> 
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

