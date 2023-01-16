//Задача 38: Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76


Console.Clear();
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int dif = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 99);
}
dif = (array.Max() - array.Min());
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine("Минимальное число массива " + array.Min());
Console.WriteLine("Максимальное число массива " + array.Max());
Console.WriteLine("Разница между максимальным и минимальным значением " + dif);