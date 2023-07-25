// Напишите программу которая выведет все натуральные числа
// от 1 до N
// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());
// string PrintNum(int start, int end)
// {
//     // Базовый случай
//     if (start == end) return start.ToString();
//     // Рекрсивный случай
//     return start + ", " + PrintNum(start + 1, end);

// }
// Console.WriteLine($"Числа от 1 до {n}: {PrintNum(1,n)}");



// Напишите программу которая на вход будет принимать число,
// и выдавать сумму его цифр

// Console.Write("Введите число ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SummNum(int num)
// {
//     if (num == 0) return 0;

//     return num % 10 + SummNum(num / 10);
// }
// Console.WriteLine($"Сумма цифр в числе {n}: {SummNum(n)}");

 

// Задача 69 Напишите программу которая на вход принимает 2 числа и 
// возводит одно число в степень другого

// Console.Write("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число ");
// int b = Convert.ToInt32(Console.ReadLine());// а само число b это степень

// int Pow(int num, int rank)
// {
//     if(rank == 1) return num;
//     if(rank == 0) return 1;

//     return num * Pow(num, rank -1);
// }
// Console.WriteLine($"{a} в степени {b} равно {Pow(a,b)}");







// Задача 64: Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.Write("Введите число N ");
// int n = Convert.ToInt32(Console.ReadLine());
// string Promejutok(int start, int end)
// {
    
//     if (start == end) return start.ToString();
    
//     return start + ", " + Promejutok(start - 1, end);

// }
// Console.WriteLine($"Числа от {n} до 1: {Promejutok(n,1)}");


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Summ(int first, int last)
// {
//     if(first == last) return first;

//     return first + Summ(first + 1 , last);
// }
// Console.WriteLine($"Сумма эелементов от {m} до {n} равна {Summ(m,n)}");



// Задача 68: Напишите программу вычисления функции Аккермана
//  с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
 Console.WriteLine(Akkerman(m, n));