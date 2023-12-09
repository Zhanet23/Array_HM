// Задача 1 (Ручной ввод массива с проверкой на вводимые значение в диапазоне [1,100])
int[] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
  Console.Write("Введите " + i + "-тый элемент от 1 до 100 включительно: "); 
   array[i] = Convert.ToInt32(Console.ReadLine());
   if ((array[i] > 100) || (array[i] < 1)) 
   {
        Console.Write("Число должно быть в диапазоне [1,100]. "); 
        i--;
   }
}
Console.WriteLine();
Console.WriteLine("Вы ввели массив:");
Console.WriteLine(String.Join("  ",array));

int count = 0;
for (int ii = 0; ii < array.Length; ii++)
{
   if ((array[ii] >=20) && (array[ii]<=90)) count++;
}
Console.WriteLine();
Console.Write("Кол-во элементов в заданном массиве со значениями в диапазоне [20,90]: " + count);

