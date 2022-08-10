Console.Write("Enter a 3-digit number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int twoFirst = Number / 10;
int secondDigit = twoFirst % 10;
Console.WriteLine(secondDigit);

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1