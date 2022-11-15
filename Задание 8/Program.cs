/* Задание №8 Написать программу, которая принимает на вход число и определяет все четные числа в интервале
от 1 до введенного чилса*/
Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write($"В интервале от 1 до {N} четных чисел нет!");
}
else
if (N >=2)
    for (int i = 2; i<=N; i++) //минимальное четное число при заданном в задании условии, поэтому и i начинается с 2
{
    if (i%2 ==0)
    {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{i} ");
    }
    else
    { // если убрать скобку работать не будет
    Console.ForegroundColor = ConsoleColor.Red; // Убрать строку что бы не отображались нечетные числа
    Console.Write($"{i} "); // Убрать строку что бы не отображались нечетные числа
    } // если убрать скобку работать не будет
}
Console.ResetColor();
