//Задача 3
//Задать массив из вещественных дробных чисел с ненулевой дробной частью.
//Найти разницу между максимальным и минимальным значением массива
Console.Write("Введите количество элементов массива: ");
int z = Convert.ToInt32(Console.ReadLine());
if (z > 0)
{
  double [] array = new double[z];
  Console.Write("Введите количество знаков после запятой: ");
  int m = Convert.ToInt32(Console.ReadLine()); // m - кол-во знаков после запятой
  if (m > 0 && m < 16)
  {
      for (int i = 0; i < array.Length; i++)
      {
        array[i] = Math.Round((new Random().NextDouble()*200),m); 
        //*200 (можно и другое) иначе выведет числа в диапазоне 0-1
        // и для удобочитаемости округляем число ДО трех знаков после запятой (в этой задаче можно и не округлять, 
        //но читать не удобно)
        Console.Write(array[i] + "|| ");
      }
      double max = array[0];
      double min = array[0];
      int ii = 1;
      while (ii < array.Length)
      {
         if (array[ii] > max) max = array[ii];
         if (array[ii] < min) min = array[ii];
         ii++;
      }
      Console.WriteLine();
      Console.WriteLine("max: " + max);
      Console.WriteLine("min: " + min);
      double delta  = Math.Round(max - min,m); //если не округлять, выдаст как хранится в double, все знаки после запятой
      Console.WriteLine("разница между максимальным и минимальным элементом массива: " + delta);
   }
   else if (m <= 0 || m >=16) Console.WriteLine("Число знаков после запятой не может быть отрицательно,больше 16 или нулевое");
}
else if (z <= 0) // z - количество элементов массива
{
  Console.WriteLine("Массив не может состоять из отрицательного или нулевого количества элементов. "); 
  Console.WriteLine("Попробуйте еще раз ввести число");
}
