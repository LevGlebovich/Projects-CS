//*я писал Вам в личку в ТГ, задача решалась в зале на семинаре
// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// System.Console.WriteLine("Введите пятизначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int a1 = a / 10000;
// int a5 = a % 10;
// int a2 = (a / 1000) % 10;
// int a4 = (a % 100) / 10;

// if (a1 == a5 && a2 == a4)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// System.Console.WriteLine("Введите точку X1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите точку Y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите точку Z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите точку X2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите точку Y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите точку Z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());


// double x = Math.Pow((x2 - x1), 2);
// double y = Math.Pow((y2 - y1), 2);
// double z = Math.Pow((z2 - z1), 2);

// double result = Math.Sqrt(x + y + z);
// System.Console.WriteLine(result);



// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// System.Console.WriteLine("Введите N: ");
// int a = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= a; i++)
// {
//     double x = Math.Pow(i, 3);
//     System.Console.Write(x + " ");
// }