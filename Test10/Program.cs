// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Первый вариант решения задачи 10.
Console.WriteLine("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = number / 10;
number = number % 10;
Console.WriteLine($"Вторая цифра трехзначного числа: {number}");

// Второй вариант решения задачи 10.
Console.WriteLine("Введите целое трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
{
    Console.WriteLine($"Вторая цифра трехзначного числа -> " +stringNumber[1]);
}
