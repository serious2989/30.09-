﻿Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); 

for (int i = (-1) * n; i <= n; i+=2)
    Console.Write(i + " ");
