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
double different = FindDifMinMax(array);
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

double FindDifMinMax(double[] arr)
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

