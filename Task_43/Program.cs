// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2

Console.Write("Задайте значение b1: ");
int b1 = int.Parse(Console.ReadLine());

Console.Write("Задайте значение k1: ");
int k1 = int.Parse(Console.ReadLine());

Console.Write("Задайте значение b2: ");
int b2 = int.Parse(Console.ReadLine());

Console.Write("Задайте значение k2: ");
int k2 = int.Parse(Console.ReadLine());

int x1 = (b2 - b1) / (k1 - k2);
int result = k1 * x + b1;

Console.WriteLine();
Console.Write($"Точка пересечения: ( {x}; {result} )");
