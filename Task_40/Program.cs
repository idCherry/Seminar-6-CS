// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник со сторонами такой длины.

Console.Write("Задайте 3 длины стороны для треугольника: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[0] + array[2] > array[1])
{
    Console.Write("Треугольник с заданными сторонами существует");
}
else Console.Write("Треугольник с заданными сторонами не существует");