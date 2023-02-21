// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double GetPow(int num1, int num2)
// {
//     double result = Math.Pow(num1, num2);
//     return result;
// }
// System.Console.WriteLine("Введите числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(GetPow(num1, num2));



// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int GetSumNums(int num)
// {
//     int result = 0;
//     for (int i = 0; num > 1; i++)
//     {
//         result = result + num % 10;
//         num = num / 10;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите числа: ");
// int num = int.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void FillArray(int[] array)
// {
//     int length = array.Length;

//     for (int index = 0; index < length; index++)
//     {
//         array[index] = new Random().Next(0, 20);
//     }
// }

// void PrintArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {        
//         Console.Write(array[i] + " ");
//     }
// }

// int[] arr = new int[8];
// FillArray(arr);
// Console.WriteLine();
// PrintArray(arr);