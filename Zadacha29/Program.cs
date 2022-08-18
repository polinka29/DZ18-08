// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


int[] array = new int[8]; 
int number = array.Length;
for (int i = 0; i < number; i++)
{
    array[i] = new Random().Next(0, 10);
}
 Console.WriteLine(string.Join(",", array));
