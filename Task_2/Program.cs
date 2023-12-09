//Задача 2
//Задает массив из 10 целых чисел и выдает количество четных чисел в массиве

Console.WriteLine("Введите число диапазона");
int R = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int[] array = new int [10]; //по условию задачи - в массиве 10 элементов
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(-R,R+1); //числа в диапазоне от -R до R
   Console.Write(array[i] + ", ");
}

int count = 0;
for (int ii = 0; ii < array.Length; ii++)
{
   if (array[ii] % 2 == 0) count++;
}
Console.WriteLine();
Console.Write("Кол-во четных чисел в заданном массиве: " + count);

