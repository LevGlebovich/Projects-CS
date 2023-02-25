// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void PrintArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($"{inArray[i]} ");
//     }
// }

// void FindEvenNumberIndex(int[] inArray)
// {
//     int result = 0;
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         if (inArray[i] % 2 == 0)
//         {
//             result++;
//         }
//     }
//     System.Console.WriteLine($"Количество четных чисел в массиве = {result}");
// }

// Console.WriteLine("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] array = GetArray(size, 100, 999);
// PrintArray(array);
// System.Console.WriteLine();
// FindEvenNumberIndex(array);






// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// void PrintArray(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         Console.Write($"{inArray[i]} ");
//     }
// }

// void GetSummOddIndexes(int[] inArray)
// {
//     int result = 0;
//     for (int i = 0; i < inArray.Length-1; i++)
//     {
//         if (i % 2 > 0)
//         {
//             result += inArray[i];
//         } 

//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях =  {result}"); 
// }

// Console.WriteLine("Введите параметры массива: ");
// int size = int.Parse(Console.ReadLine());
// int min = int.Parse(Console.ReadLine());
// int max = int.Parse(Console.ReadLine());
// int[] array = GetArray(size, min, max);
// PrintArray(array);
// GetSummOddIndexes(array);



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] inArray)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Массив: ");
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

void GetResultValue(int[] inArray)
{
    int max = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > max)
        {
            max = inArray[i];
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Максимальное число в массиве: {max}");
    System.Console.WriteLine();
    int min = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] < min)
        {
            min = inArray[i];
        }
    }
    System.Console.WriteLine($"Минимальное число в массиве: {min}");
    System.Console.WriteLine();
    System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min}");
}


Console.WriteLine("Введите параметры массива: ");
int size = int.Parse(Console.ReadLine());
int minvalue = int.Parse(Console.ReadLine());
int maxvalue = int.Parse(Console.ReadLine());
int[] array = GetArray(size, minvalue, maxvalue);
PrintArray(array);
System.Console.WriteLine();
GetResultValue(array);
