// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int countPositive(int[] arr1)   // Метод подсчёта положительных чисел.
{
   int count = arr1.Count(i => i > 0);
   return count;
}

Console.WriteLine("Введите необходимые вам числа через пробел, по окончанию ввода нажмите Enter: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
Console.WriteLine("Количество чисел больше нуля: " + countPositive(array));