// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[]array = GetRandomArray(10, 100, 999);
// Console.WriteLine($"[{String.Join(",", array)}]");
// Console.WriteLine(FindElement(array));

// // -------------------------------Общий метод-------------------------------------------
// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }

//     return result;
// }

// // -------------------------------Общий метод-------------------------------------------
// int FindElement(int[] array)
// {
//     int count = 0;
//     foreach (int el in array)
//     {
//         if (el % 2 == 0) count++;
//     }
//     return count;
// }

// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[]array = GetRandomArray(10, 0, 99);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(SumElement(array));

// -------------------------------Общий метод-------------------------------------------
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

// -------------------------------Общий метод-------------------------------------------
int SumElement(int[] array)
{
    int sum = 0;
    int i = 1;
    while (i <= array.Length)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}