﻿// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"  N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void NaturalNamber(int N)
{
    if(N < 1) return;
    Console.Write($"{N} ");
    N--;
    DescentNums(N);
}

int N = 15;
NaturalNamber(N);

