// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите трехзначное число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int j = (i / 10) % 10;
// System.Console.WriteLine(j);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());

// if (i > 999)
// {
//     for (int j = 0; i > 999; j++)
//     {
//         i = i / 10;
//     }
//     int j2 = i % 10;
//     System.Console.WriteLine(j2);
// }
// else if (i > 99 && i < 1000)
// {
//     int j3 = i % 10;
//     System.Console.WriteLine(j3);
// }
// else if (i < 100)
// {
//     System.Console.WriteLine("Третьей цифры нет");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру деня недели: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i > 0 && i < 8)
{
    if (i > 5)
    {
        System.Console.WriteLine("Сегодня выходной");
    }
    else
    {
        System.Console.WriteLine("Сегодня рабочий день");
    }
}
else
{
    System.Console.WriteLine("Это не день недели");
}