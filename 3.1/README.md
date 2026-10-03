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
            int number = int.Parse(Console.ReadLine());
            if (number > 0) Console.WriteLine("Число положительное");
            else Console.WriteLine("Число отрицательное");
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
            Console.Write("Введите целое число: ");

            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0 ) Console.WriteLine("Число четное");
            else Console.WriteLine("Число нечетное");
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
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.Write($"наибольшее число: {number1}");
            }

            else
            {
                Console.Write($"наибольшее число: {number2}");
            }
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
            Console.Write("Введите первое число: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            if (number1 < number2)
            {
                Console.WriteLine($"Наименьшее число: {number1}");
            }

            else
            {
                Console.WriteLine($"Наименьшее число: {number2}");
            }
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
            Console.Write("Введите число: ");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 % 5 == 0)
            {
                Console.WriteLine($"Число {number1} делится на 5");
            }

            else
            {
                Console.WriteLine($"Число {number1} не делится на 5");
            }
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
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 10 == 0)
            {
                Console.WriteLine($"Число {number} заканчивается нулем");
            }

            else
            {
                Console.WriteLine($"Число {number} не заканчивается нулем");
            }

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
            Console.Write("Введите температуру воздуха: ");
            int t = int.Parse(Console.ReadLine());

            if (t < 0)
            {
                Console.WriteLine($"Температура воздуха {t}, на улице мороз, наденьте шапку");
            }

            else
            {
                Console.WriteLine($"Температура воздуха {t}, надевать шапку необязательно");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 100)
            {
                Console.WriteLine($"Результат: {number -= 20}");
            }

            else
            {
                Console.WriteLine($"Результат: {number += 10}");
            }
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
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"Числа равны");
            }

            else
            {
                Console.WriteLine($"{number1 + number2}");
            }
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
            Console.Write("Введите свой возраст: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Доступ разрешен");
            }

            else
            {
                Console.WriteLine("Доступ запрещен");
            }
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
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <=999)
            {
                Console.WriteLine($"Число {number} является трехзначным");
            }

            else
            {
                Console.WriteLine($"Число {number} не является трехзначным");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0)
            {
                Console.WriteLine($"Число {number} делится на 3 без остатка");
            }

            else
            {
                Console.WriteLine($"Число {number} не делится на 3 без остатка");
            }
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
            Console.Write("Введите координату точки на числовой прямой X: ");
            int point = int.Parse(Console.ReadLine());

            if (point > 0)
            {
                Console.WriteLine($"Координата {point} лежит правее нуля");
            }

            else
            {
                Console.WriteLine($"Координата {point} лежит левее нуля");
            }
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
            Console.Write("Введите баланс счета: ");
            int balance = int.Parse(Console.ReadLine());

            if (balance > 0)
            {
                Console.WriteLine($"На баласе {balance} рублей");
            }

            else
            {
                Console.WriteLine("Задолженность!");
            }
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
            Console.Write("Введите пароль: ");
            int password = int.Parse(Console.ReadLine());

            if (password == 1234)
            {
                Console.WriteLine("Вход выполнен");
            }

            else
            {
                Console.WriteLine("Неверный пароль");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 )
            {
                Console.WriteLine($"Число {number} отрицательное");
            }

            else
            {
                Console.WriteLine($"Число {number} положительное");
            }
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
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            int res = (Math.Abs(number1 - number2));

            Console.WriteLine($"Разность равна: {res}");
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
            Console.Write("Введите сумму покупки: ");
            int price = int.Parse(Console.ReadLine());

            if (price > 1000) 
            {
                int priceiskidka = price * 5 / 100;
                int result = price - priceiskidka;
                Console.WriteLine($"Сумма покупки превышает 1000 рублей, вам пологается скидка в размере 5%. К оплате: {result}");
            }

            else
            {
                Console.WriteLine($"К оплате {price}");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                int numberdelit = number / 2;
                Console.WriteLine($"Число четное, следовательно делим на 2. Ответ: {numberdelit}");
            }

            else
            {
                int numberumnojit = number * 3;
                Console.WriteLine($"Число нечетное, следовательно умножаем на 3. Ответ: {numberumnojit}");
            }
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
            Console.Write("Введите скорость движения: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed > 90)
            {
                Console.WriteLine("Вы превысили скорость, вам выписан штраф");
            }

            else
            {
                Console.WriteLine("Вы ничего не превысили");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine("Число равно нулю");
            }

            else
            {
                Console.WriteLine("Число не равно нулю");
            }
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
            Console.Write("Введите первое число: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Введите первое число: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            if (number1 == number2)
            {
                Console.WriteLine($"Числа {number1:F3} и {number2:F3} равны");
            }

            else
            {
                Console.WriteLine($"Числа {number1:F3} и {number2:F3} не равны");
            }
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
            Console.Write("Введите первое число: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int B = int.Parse(Console.ReadLine());

            if (A % B == 0)
            {
                Console.WriteLine($"Число {A} делится на {B} без остатка");
            }

            else
            {
                Console.WriteLine($"Число {A} делится на {B} с остатком");
            }
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
            Console.Write("Введите величину первого угла: ");
            int corner1 = int.Parse(Console.ReadLine()); 

            Console.Write("Введите величину второго угла: ");
            int corner2 = int.Parse(Console.ReadLine());

            if (corner1 + corner2 >= 180)
            {
                Console.WriteLine("Такой треугольник не существует");
            } 

            else
            {
                Console.WriteLine("Такой треугольник существует");
            }
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
            Console.Write("Введите радиус круга: ");
            decimal r = decimal.Parse(Console.ReadLine());

            Console.Write("Введите сторону квадрата: ");
            decimal side = decimal.Parse(Console.ReadLine());

            const decimal Pi = 3.14m;
            decimal S1 = Pi  * (r * r);
            decimal S2 = side * side;

            if (S1 > S2)
            {
                Console.WriteLine($"Площадь круга больше {S1}");
            }

            else
            {
                Console.WriteLine($"Площадь квадрата больше {S2}");
            }
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
            Console.Write("Введите первое число: ");
            decimal number1 = decimal.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            if (number1 == 0 || number2 == 0)
            {
                Console.Write("Деление на 0 невозможно");
            }

            else if (number1 > number2)
            {
                Console.Write($"Результат {number1 / number2}");
            }

            else if (number2 > number1)
            {
                Console.Write($"Результат {number2 / number1}");
            }

            else
            {
                Console.Write($"Числа равны");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()); 

            if (number % 10 == 7)
            {
                Console.Write($"Последняя цифра чила {number} равна 7");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()); 

            if (number % 2 != 0 && number > 0)
            {
                Console.WriteLine($"Число {number} нечетное и положительное ");
            }

            else
            {
                Console.WriteLine("Число четное или отрицательное");
            }
            
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
            Console.Write("Введите объем свободного места на диске: ");
            int freeGB = int.Parse(Console.ReadLine()); 

            if (freeGB < 5)
            {
                Console.WriteLine($"На диске мало места");
            }

            else
            {
                Console.WriteLine($"На диске еще есть место");
            }
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
            Console.Write("Оценка: ");
            int mark = int.Parse(Console.ReadLine());

            if (mark == 5 || mark == 4)
            {
                Console.WriteLine("Молодец");
            }

            else if (mark == 2 || mark == 3)
            {
                Console.WriteLine("Нужно подтянуться");
            }

            else
            {
                Console.WriteLine("таких оценок нет");
            }
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
            Console.Write("Введите символ: ");
            string symbol1 = (Console.ReadLine());

            Console.Write("Введите символ: ");
            string symbol2 = (Console.ReadLine());

            if (symbol1 == symbol2)
            {
                Console.WriteLine("Символы совпадают");
            }

            else
            {
                Console.WriteLine("Символы не совпадают");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0 && number % 7 == 0 )
            {
                Console.Write("Кратно 14");
            }
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
            Console.Write("Введите массу груза: ");
            decimal tonn = decimal.Parse(Console.ReadLine());

            if (tonn > 3.5m)
            {
                Console.WriteLine("Перегруз!");
            }

            else
            {
                Console.WriteLine("Еще место есть");
            }
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
            Console.Write("Введите время: ");
            int time = int.Parse(Console.ReadLine());

            if (time > 6 && time <= 12)
            {
                Console.WriteLine("Доброе утро");
            }

            else if (time > 12 && time <= 16)
            {
                Console.WriteLine("Добрый день");
            }

            else if (time > 16 && time < 23)
            {
                Console.WriteLine("Добрый Вечер");
            }

            else
            {
                Console.WriteLine("Ошибка");
            }
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
            Console.Write("Введите рост: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 200)
            {
                Console.WriteLine("Очень высокий");
            }

            else
            {
                Console.WriteLine("Скип задачи");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            int number1 = number / 10;
            int number2 = number % 10;

            if (number1 > number2)
            {
                Console.WriteLine($"Первая цифра числа {number} больше");
            }

            else if (number2 > number1)
            {
                Console.WriteLine($"Вторая цифра числа {number} больше");
            }

            else
            {
                Console.WriteLine("Числа равны");
            }
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
            Console.Write("Введите цену товара: ");
            int price = int.Parse(Console.ReadLine());

            if (price == 0)
            {
                Console.WriteLine("Акция!");
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
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            int number1 = number / 10;
            int number2 = number % 10;

            if (number1 == number2)
            {
                Console.WriteLine("число содержит одинаковые цифры");
            }

            else
            {
                Console.WriteLine("не содержит");
            }
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
            Console.Write("Введите уровень громкости: ");
            int gromkost = int.Parse(Console.ReadLine());

            if (gromkost > 80)
            {
                Console.WriteLine("Слишком громко для слуха");
            }

            else
            {
                Console.WriteLine("Нормально");
            }
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
            Console.Write("Введите первое Число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе Число: ");
            int number2 = int.Parse(Console.ReadLine());

            int summ = number1 + number2;
            int raznost = number1 - number2;

            if (summ % 2 == 0)
            {
                Console.WriteLine($"Четная: {summ}");
            }

            else
            {
                Console.WriteLine($"Не четная: {raznost}");
            }
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
            Console.Write("Введите количество страниц в документе: ");
            int paper = int.Parse(Console.ReadLine());

            if (paper > 100)
            {
                Console.WriteLine("Двухсторонняя печать включена");
            }
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
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());

            int res = (int)Math.Sqrt(number);

            if (res * res == number)
            {
                Console.WriteLine($"Введенное целое число {number} является полным квадратом");
            }

            else 
            { 
                Console.WriteLine("Число не является полным квадратом"); 
            }
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
            Console.Write("Введите атмосферное давление: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 740)
            {
                Console.WriteLine("Пониженное даление");
            }

            else
            {
                Console.WriteLine("Повышенное даление");
            }
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
            Console.Write("Введите количество забитых мячей команды A: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите количество забитых мячей команды B: ");
            int B = int.Parse(Console.ReadLine());

            if (A > B)
            {
                Console.WriteLine($"Команда A выйграла со счетом {A}:{B}");
            }

            else if (B > A)
            {
                Console.WriteLine($"Команда B выйграла со счетом {B}:{A}");
            }

            else
            {
                Console.WriteLine("Ничья");
            }
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
            Console.Write("Введите отрийцательное число: ");
            int number = int.Parse(Console.ReadLine());

            int res = number * -1;

            Console.WriteLine($"Ответ {res}");
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
            Console.Write("Введите показатель уровня сахара в крови: ");
            decimal number = decimal.Parse(Console.ReadLine());

            if (number > 6.1m)
            {
                Console.WriteLine("Выше нормы");
            }

            else
            {
                Console.WriteLine("Норма");
            }
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
            Console.Write("Введите, сколько средств на счете: ");
            int rub = int.Parse(Console.ReadLine());

            if (rub >= 35)
            {
                Console.WriteLine("Денег на оплату проезда хватит");
            }

            else
            {
                Console.WriteLine("Денег не хватит");
            }
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
            Console.Write("Введите этаж: ");
            int etaj = int.Parse(Console.ReadLine());

            if (etaj > 10)
            {
                Console.WriteLine("Высокий этаж");
            }
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
            Console.Write("Введите первое слово: ");
            string word1 = (Console.ReadLine());
            int length1 = word1.Length;

            Console.Write("Введите второе слово: ");
            string word2 = (Console.ReadLine());
            int length2 = word2.Length;

            if (length1 > length2)
            {
                Console.WriteLine("Первое слово длиннее");
            }

            else if (length2 > length1)
            {
                Console.WriteLine("Второе слово длиннее");
            }
            else
            {
                Console.WriteLine("Все слова одинаковые по длинне");
            }
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
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }

            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
```
---
