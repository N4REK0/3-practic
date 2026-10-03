# Практическая работа №3
## Выполнил студент группы П25-2.1. Оганджанян Нарек Артёмикович

### Раздел 1. Базовые условия if и if-else
---
№ 1. Пользователь вводит целое число. Проверить, является ли оно положительным.

<picture> <img src="3.1. Арифметические операторы/1 задача.png.jpg"> 
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
            Console.WriteLine("Вычисление результата");

            int x = 17 / 5;
            int y = 17 % 5;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
        }
    }
}
```
---
№ 2. Пользователь вводит целое число. Проверить, является ли оно четным.

<picture> <img src="3.1. Арифметические операторы/2 задача.png.jpg"> 
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
            Console.WriteLine("Вычислите значение res");

            int a = 5;
            int res = ++a * 2;

            Console.WriteLine($"res = {res}");
        }
    }
}


```

---
№ 3.Даны два целых числа. Вывести наибольшее из них.

<picture> <img src="3.1. Арифметические операторы/3 задача.png.jpg"> 
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
            Console.WriteLine("Значение res: ");

            int a = 5;
            int res = a++ * 2;

            Console.Write($"res = {res}");
        }
    }
}
```

----
№ 4. Даны два числа с плавающей точкой. Вывести наименьшее.

<picture> <img src="3.1. Арифметические операторы/4 задача.png.jpg"> 
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
            int c = 7 / 2;
            decimal p = 7.0m / 2;

            console.writeline($"решение целочисленного делеия: {c}");
            console.writeline($"решение целочисленного делеия: {p}");
        }
    }
}
```

---
№ 5. Проверить, делится ли введенное число нацело на 5.

<picture> <img src="3.1. Арифметические операторы/5 задача.png.jpg"> 
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
            console.writeline("вычислите результат: ");

            int q = -15 % 4;

            console.writeline($"результат: {q}");
        }
    }
}
```

---
№6. Проверить, оканчивается ли введенное целое число нулем.

<picture> <img src="3.1. Арифметические операторы/6 задача.png.jpg"> 
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
            console.writeline("вычислите: ");

            int x = 10;
            x = x++ + ++x;

            console.writeline($"решение {x}");
            
        }
    }
}
```

---
№7. Пользователь вводит температуру воздуха. Если она ниже нуля, вывести: «На улице мороз, наденьте шапку».

<picture> <img src="3.1. Арифметические операторы/7 задача.png.jpg"> 
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
            int max = int.maxvalue;
            int res = checked(max + 1);

            console.writeline($"вывод {res}");
        }
    }
}
```

---
№8. Дано число. Если оно больше 100, уменьшить его на 20, иначе увеличить на 10.

<picture> <img src="3.1. Арифметические операторы/8 задача.png.jpg"> 
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
            int max = int.maxvalue;
            int res = unchecked(max + 1);

            console.writeline($"вывод {res}");
            
        }
    }
}
```

---
№ 9. Ввести два числа. Если они равны, вывести «Числа равны», иначе вывести их произведение.

<picture> <img src="3.1. Арифметические операторы/9 задача.png.jpg"> 
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
            console.writeline("вычислите: ");

            double x = 1.0 / 0.0;
            double y = 0.0 / 0.0;

            console.writeline($"x = {x}");
            console.writeline($"y = {y}");
        }
    }
}
```

---
№ 10. Пользователь вводит свой возраст. Если возраст от 18 и старше, вывести «Доступ разрешен», иначе «Доступ запрещен».

<picture> <img src="3.1. Арифметические операторы/10 задача.png.jpg"> 
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
            int a = 8;
            int b = 3;
            int c = a - b * 2 + a / b;

            console.writeline($"c = {c}");
            
        }
    }
}
```
---
№ 11. Ввести число. Если оно трехзначное, вывести «Да», иначе «Нет».

<picture> <img src="3.2. Операторы сравнения и равенства/1.jpg"> 
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
            bool x = 5 > 3;
            bool y = 5 >= 5;

            console.writeline($"x = {x}");
            console.writeline($"y = {y}");
        }
    }
}
```

---
№ 12. Проверить, делится ли число на 3 без остатка.

<picture> <img src="3.2. Операторы сравнения и равенства/2.jpg"> 
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
            bool x = "hello" == "hello";

            console.writeline($"{x}");
        }
    }
}
```

---
№ 13. Даны координаты точки на числовой прямой X. Определить, лежит ли точка правее нуля.

<picture> <img src="3.2. Операторы сравнения и равенства/3.jpg"> 
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
            bool x = double.nan == double.nan;

            console.writeline($"{x}");
        }
    }
}
```
---
№ 14. Ввести баланс счета. Если баланс отрицательный, вывести «Задолженность!».

<picture> <img src="3.2. Операторы сравнения и равенства/4.jpg"> 
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
            object a = new int[] { 1 };
            object b = new int[] { 1 };

            bool r = a == b;

            console.writeline($"r = {r}");
        }
    }
}
```

---
№ 15. Пользователь вводит пароль (целое число). Если введен 1234, вывести «Вход выполнен», иначе «Неверный пароль».

<picture> <img src="3.2. Операторы сравнения и равенства/5.jpg"> 
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
                        bool x = 10 != 10.0;

            console.writeline($"x = {x}");
            
        }
    }
}
```

---
№ 16. Проверить, является ли введенное число отрицательным.

<picture> <img src="3.2. Операторы сравнения и равенства/6.jpg"> 
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
            bool x = null == null;

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 17. Даны два числа. Вывести разность большего и меньшего числа.

<picture> <img src="3.2. Операторы сравнения и равенства/7.jpg"> 
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
            bool x = (3 < 5) == (10 >= 20);

            console.writeline($"x = {x}");
        }
    }
}
```

---
№18. Ввести сумму покупки. Если сумма превышает 1000 рублей, предоставить скидку 5% и вывести итоговую цену.

<picture> <img src="3.2. Операторы сравнения и равенства/8.jpg"> 
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
            bool res = 4 <= 4 && 5 > 2;

            console.writeline($"res = {res}");
        }
    }
}
```

---
№ 19. Ввести число. Если оно четное, разделить его на 2, если нечетное — умножить на 3.

<picture> <img src="3.2. Операторы сравнения и равенства/9.jpg"> 
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
            char c = 'b';
            bool res = c > 'a';

            console.writeline($"res = {res}");
            
        }
    }
}
```

---
№20. Пользователь вводит скорость движения. Если скорость выше 90 км/ч, вывести сообщение о нарушении.

<picture> <img src="3.2. Операторы сравнения и равенства/10.jpg"> 
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
            bool r = -0.0 > 0.0;

            console.writeline($"r = {r}");
            
        }
    }
}
```

Блок 3.3. Логические операторы
-
№ 21. Дано целое число. Проверить, равно ли оно нулю.

<picture> <img src="3.3 Логические операторы/1 задача.png.jpg"> 
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
            bool x = !true || false && true;

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 22. Ввести два вещественных числа. Проверить, равны ли они с точностью до 0.001.

<picture> <img src=""> 
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
            
            bool x = false && foo();

            console.writeline($"x = {x}");
            
        }
    }
}
```
---
№ 23. Проверить, делится ли число A на число B без остатка.

<picture> <img src=""> 
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
           int x = false & foo();

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 24. Даны два угла треугольника в градусах. Проверить, существует ли такой треугольник (сумма меньше 180).

<picture> <img src="3.3 Логические операторы/4 задача.png.jpg"> 
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
            bool x = true ^ false ^ true;

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 25. Ввести радиус круга и сторону квадрата. Определить, у какой фигуры площадь больше.

<picture> <img src="3.3 Логические операторы/5 задача.png.jpg"> 
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
            bool x = !(5 > 2 || 3 < 1);

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 26. Ввести два числа. Вывести частное большего на меньшее (предусмотреть проверку деления на 0).

<picture> <img src="3.3 Логические операторы/6 задача.png.jpg"> 
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
            bool a = true, b = false;
            bool c = a && !b || b && !a;

            console.writeline($"c = {c}");
        }
    }
}
```

---
№ 27. Проверить, является ли последняя цифра числа семеркой.

<picture> <img src="3.3 Логические операторы/7 задача.png.jpg"> 
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
            int x = 10;

            bool result = true || (x / 0 == 1);

            console.writeline($"res = {result}");
        }
    }
}
```

---
№ 28. Дано число. Если оно нечетное и положительное, вывести «Да».

<picture> <img src="3.3 Логические операторы/8 задача.png.jpg"> 
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
           bool x = false & (10 / 0 == 1);

            console.writeline($"x = {x}");
            
        }
    }
}
```

---
№ 29. Ввести объем свободного места на диске (в ГБ). Если места меньше 5 ГБ, вывести предупреждение.

<picture> <img src="3.3 Логические операторы/9 задача.png.jpg"> 
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
            bool a = true, b = false;
            bool morgan = !(a && b);
            bool morganequivalent = !a || !b;

            console.writeline($"{morgan}, {morganequivalent}");
            
        }
    }
}
```

---
№ 30. Пользователь вводит оценку (2, 3, 4, 5). Если оценка 4 или 5, вывести «Молодец», иначе «Нужно подтянуться».

<picture> <img src="3.3 Логические операторы/10 задача.png.jpg"> 
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
            bool a = true, b = false;
            bool morgan = !(a || b);
            bool morganequivalent = !a && !b;

            console.writeline($"{morgan}, {morganequivalent}");
            
        }
    }
}
```
---

№ 31. Даны два символа. Проверить, совпадают ли они.

<picture> <img src="3.4/1 задача.png"> 
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
            int res = 5 & 3;

            console.writeline($"result = {res}");
            
        }
    }
}
```

---
№ 32. Ввести число. Если оно кратно и 2, и 7, вывести «Кратно 14».

<picture> <img src="3.4/2 задача.png"> 
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
            int res = 5 | 3;

            console.writeline($"result = {res}");
            
        }
    }
}
```
---
№ 33. Ввести массу груза. Если масса превышает допустимые 3.5 тонны, вывести «Перегруз!».

<picture> <img src="3.4/3 задача.png"> 
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
            int res = 5 ^ 3;

            console.writeline($"result = {res}");
        }
    }
}
```
---
№ 34. Ввести текущее время (часы от 0 до 23). Если время от 6 до 12, вывести «Доброе утро».

<picture> <img src="3.4/4 задача.png"> 
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
            int res = ~0;

            console.writeline($"result = {res}");
            
        }
    }
}
```
---
№ 35. Ввести рост человека в см. Если рост больше 200 см, вывести «Очень высокий».

<picture> <img src="3.4/5 задача.png"> 
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
            int res = 1 << 4;

            console.writeline($"result = {res}");
            
        }
    }
}
```
---
№ 36. Дано двузначное число. Определить, какая из его цифр больше.

<picture> <img src="3.4/6 задача.png"> 
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
             int res = 40 >> 2;

             console.writeline($"{res}");
            
        }
    }
}
```
---
№ 37. Ввести стоимость товара. Если товар бесплатный (цена 0), вывести «Акция!».

<picture> <img src="3.4/7 задача.png"> 
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
            int n = 10;
            bool x = (n & 8) != 0;
            bool y = (n & (1 << 3)) != 0;
            if (x)
            {
                console.writeline("3-й бит установлен");
            }
            else
            {
                console.writeline("3-й бит не установлен");
            }
            
        }
    }
}
```
---
№ 38. Проверить, содержит ли введенное двузначное число одинаковые цифры.

<picture> <img src="3.4/8 задача.png"> 
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
            int n = 8;
            n |= (1 << 2);
            console.writeline($"n = {n}");
        }
    }
}
```
---
№ 39. Ввести уровень громкости (0–100). Если громкость превышает 80, вывести «Слишком громко для слуха».

<picture> <img src="3.4/9 задача.png"> 
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
            int n = 20;
            n &= ~(1 << n);
            console.writeline($"n = {n}");
            
        }
    }
}
```
---
№ 40. Даны два числа. Если их сумма четная, вывести сумму, иначе вывести их разность.

<picture> <img src="3.4/10 задача.png"> 
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
            int x = (-16) >> 2;
            console.writeline($"x = {x}");
        }
    }
}
```
---
№ 41. Ввести количество страниц в документе. Если страниц больше 100, включить двухстороннюю печать.

<picture> <img src="3.5/1.png"> 
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
            int x = 10;
            x += 5; // += прибавляет к текущему значению в переменной 5 и сохраняет в ней обновленное значение

            console.writeline($"x = {x}");
        }
    }
}
```

---
№   42. Проверить, является ли введенное целое число полным квадратом (для проверки использовать Math.Sqrt).

<picture> <img src="3.5/2.png"> 
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
            int a = 10;
            a *= 2 + 3; // то же самое действие что и в предыдущей задаче только с умножением

            console.writeline($"a = {a}");
        }
    }
}
```

---
№ 43. Ввести атмосферное давление. Если давление ниже 740 мм рт. ст., вывести «Пониженное давление».

<picture> <img src="3.5/3.png"> 
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
            int x = 12;
            x >>= 2; // сдвиг битов вправо тоесть если число 12 было 1100 бит мы сдвинули направо и в итоге получили 0011 что значит 3

            console.writeline($"x = {x}");
        }
    }
}
```

---
№ 44. Ввести количество забитых мячей командами А и Б. Вывести победителя или сообщить о ничьей.

<picture> <img src="3.5/4.png"> 
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
            int? x = null;
            int y = 5;
            x = x ?? y;

            console.writeline($"x = {x}");
        }
    }
}
```
---
№ 45. Дано число. Заменить его на абсолютную величину (модуль) без использования Math.Abs.

<picture> <img src="3.5/5.png"> 
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
            string str = null;
            str = str ?? "default";
            str = str ?? "custom"; // получается, если стоит ?? это означает взять информацию справа если слево пусто 

            console.writeline($"str = {str}");
        }
    }
}
```
---
№ 46. Ввести показатель уровня сахара в крови. Если показатель выше 6.1 ммоль/л, вывести «Выше нормы».

<picture> <img src="3.5/6.png"> 
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
            byte b = 1;
            b += 2;

            console.writeline($"b = {b}");
        }
    }
}
```
---
№ 47. Проверить, хватит ли пользователю средств на счете для оплаты проезда стоимостью 35 рублей.

<picture> <img src="3.5/7.png"> 
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
            int a = 5, b = 10, c = 0;
            c = a = b; // просто присваиваются значение из переменной b (10) в переменную a и c

            console.writeline($"c = {c}");
            console.writeline($"a = {a}");
        }
    }
}
```
---
№ 48. Ввести номер текущего этажа. Если этаж выше 10, вывести «Высотный этаж».

<picture> <img src="3.5/8.png"> 
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
            int mask = 1;
            mask <<= 3; // сдвиг битов влево на 3
            mask |= 2; // |= это побитовое или если у нас чило 8 это 1000 бит и 2 это 0010 то получается 1010 что означает 10

            console.writeline($"mask = {mask}");
        }
    }
}
```
---
№ 49. Ввести два слова. Проверить, одинаковы ли они по длине.

<picture> <img src="3.5/9.png"> 
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
            int x = 15;
            x %= 4; // %=  означает деление числа и записать целый остаток обратно в переменную 

            console.writeline($"x = {x}");
        }
    }
}
```
---
№ 50. Пользователь вводит целое число. Вывести строковое сообщение: «Число четное» либо «Число нечетное».

<picture> <img src="3.5/10.png"> 
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
            int x = 7;
            x ^= 7;

            console.writeline($"x = {x}");
        }
    }
}
```
---
