// // Задача 25:
// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵);   2, 4 -> 16 

// int numberA = ReadInt("Введите число: ");
// int numberB = ReadInt("Введите степень: ");
// ToDegree(numberA, numberB);



// void ToDegree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result = result * a;
//     }
//     Console.WriteLine(a + " в степени " + b + " = " + result);
// }

// int ReadInt(string message)
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11;  82 -> 10;  9012 -> 12

// int number = ReadInt("Введите число: ");

// int len = NumberLen(number);
// SumNumbers(number, len);

// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }

// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine($"сумма цифр {sum}");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }