// Задание №2 Написать программу которая получает на вход два числа и определяет большее и меньшее из них
Console.WriteLine("Введите два числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a>b) 
Console.WriteLine($"{a} большее число, а {b} меньшее число");
else
Console.WriteLine($"{a} меньшее числоа, а {b} большее число");
