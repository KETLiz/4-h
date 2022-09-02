// See https://aka.ms/new-console-template for more information

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = {1, 3, 6, 8, 34, 12, 72, 9};
for (int i = 0; i < arr.Length; i++)
{
    if (i != arr.Length - 1) Console.Write($"{arr[i]}, ");
    else Console.Write(arr[i]);
}

