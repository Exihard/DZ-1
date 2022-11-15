/// Задание №6 Написать программу, которая принимает на вход число и определяет четное оно или нет
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

if (a%2 == 0) 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{a} четное");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"{a} нечетное");
}
Console.ResetColor();