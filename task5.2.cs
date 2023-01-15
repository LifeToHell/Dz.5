//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int count = 0;
int sum = 0;
for(int i = 0; i < array.Length; i++){
array[i] = new Random(). Next(0,99);
} 
Console.WriteLine($"[{string.Join(",", array)}]");

for (int z = 0; z < array.Length; z++)
if (array[z] % 2 == 1){
   sum = sum + array[z]; 
   count++;
}

Console.WriteLine($"всего {array.Length} чисел, {count} из них не чётные");
Console.WriteLine("Сумма элементов с нечетными номерами (нумерация начинается с нуля): {0} ", sum);