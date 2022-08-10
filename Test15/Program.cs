// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Задача 15. ");
Console.WriteLine("Введите цифру, обозначающую день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine("Да! Сегодня выходной!");

}
if (number < 1 || number > 7)
{
    Console.WriteLine("Это, вообще, не день недели");
}
else
{
    Console.WriteLine("Нет. Сегодня на выходной.");
}
