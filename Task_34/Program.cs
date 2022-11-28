// Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов массива:\t");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
FillArray(array);
PrintArray(array);
Console.WriteLine($"{"Количество четных чисел:\t",33}{FindNumberEven(array)}");

int FindNumberEven(int[] arr)
{
    int amounts = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0)
        {
            amounts++;
        }
    }
    return amounts;
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.WriteLine($"{arr[i]}");
        }
        else
        {
            Console.Write($"{arr[i]}, ");
        }
    }
}

