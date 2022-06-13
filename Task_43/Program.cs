// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2

Console.Write("Задайте значение b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Задайте значение k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Задайте значение b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Задайте значение k2: ");
double k2 = double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double result = k1 * x + b1;

Console.WriteLine();
Console.Write($"Точка пересечения: ( {x}; {result} )");
