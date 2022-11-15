// Задание №4 Написать программу, которая принимает на вход три числа и определяет большее из них
Console.WriteLine("Введите три числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a>b) 
max = a;
else
max = b;
    if (max>d)
    Console.WriteLine($"{max} большее число");
    else
    Console.WriteLine($"{d} большее число");
