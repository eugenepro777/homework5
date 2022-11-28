/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Write("Введите количество элементов массива:\t");
int number = Convert.ToInt32(Console.ReadLine());

double[] array = new double[number];

FillArray(array);
PrintArray(array);
// FindDifMaxMin(array);
Console.WriteLine();
double different = FindMinMax(array);
Console.Write($"\tРазница = {Math.Round(different, 4)}");


void FillArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.WriteLine($"{Math.Round(arr[i], 4)}");
        }
        else
        {
            Console.Write($"{Math.Round(arr[i], 4)},  ");
        }
    }
}

double FindMinMax(double[] arr)
{
    int indexNumberMax = 0;
    int indexNumberMin = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > arr[indexNumberMax])
        {
            indexNumberMax = i;
        }
        else if (arr[i] < arr[indexNumberMin])
        {
            indexNumberMin = i;
        }
    }
    if (arr.Length <= 1) return 0;
    double result = arr[indexNumberMax] - arr[indexNumberMin];
    return result;
}

// void FindDifMaxMin(double[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < arr.Length; j++)
//         {
//             if (arr[j] > arr[maxPosition]) maxPosition = j;
//         }
//         double temporary = arr[i];
//         arr[i] = arr[maxPosition];
//         arr[maxPosition] = temporary;
//     }
//     double different = arr[0] - arr[arr.Length - 1];
//     Console.WriteLine($"Разница = {different}");
// }