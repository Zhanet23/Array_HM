﻿//Задача 1 (Элементы массива вводятся программой рандомно)
//задается одноме// Задача 1 (Элементы массива вводятся программой рандомно)
//задается одномерный массив из 10 целых чисел от 1 до 100 включительно.
//Найти количество элементов массива, значения которых лежат в отрезке [20,90]
int[] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(1,101);
   Console.Write(array[i] + " ");
}

int count = 0;
for (int ii = 0; ii < array.Length; ii++)
{
   if ((array[ii] >=20) && (array[ii]<=90)) count++;
}
Console.WriteLine();
Console.Write("Кол-во элементов в заданном массиве со значениями в диапазоне [20,90]: " + count);

