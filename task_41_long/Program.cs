// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void fillArray (int[] arr)      // Метод для ввода чисел пользователем и преобразования их в массив.
{
   int length = arr.Length;
   for (int index = 0; index < length; index++)
      {
      Console.WriteLine("Введите число под номером " + index);
      arr[index] = Convert.ToInt32(Console.ReadLine());
      }
}

int countPositive(int[] arr1)   // Метод подсчёта положительных чисел.
{
   int count = arr1.Count(i => i > 0);
   return count;
}

Console.WriteLine("Введите количество чисел, среди которых вы хотите узнать количество положительных(номерация нацинается с нуля):");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[x];  

fillArray(array);

Console.WriteLine("Введённые вами числа:");
Console.Write(string.Join(" ", array));
Console.WriteLine();
Console.WriteLine("Количество чисел больше нуля: " + countPositive(array));