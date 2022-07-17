// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] fillArray(int n)        // Метод заполнения массива
{
   int[] arr = new int [n];
   for (int i = 0; i < arr.Length; i++)
   {
   arr[i] = new Random().Next(100, 1000);
   }
   return arr;
}

int [] copyArray(int[] arr)     // Метод копирования заданного массива в новый массив.
{
   int[] copyArr = new int[arr.Length];
   for (int i = 0; i < arr.Length; i++)
   {
   for (int j = 0; j < copyArr.Length; j++)
      {
      copyArr[j] = arr[i];
      }
   }
   return arr;
}

int[] array = fillArray(8);
Console.WriteLine(string.Join("|", array));     // Вывод массива для проверки правильности решения.

int[] copArray = copyArray(array);
Console.WriteLine(string.Join("|", copArray));