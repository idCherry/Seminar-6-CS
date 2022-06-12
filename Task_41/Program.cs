// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int count = 0;

int[] array = new int[size];

Console.Write("Массив [ ");
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-10, 10);
    Console.Write(array[i] + " ");
}
Console.Write("]");

Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if (array[i] > 0) count += 1;
}

Console.WriteLine($"Количество чисел больше нуля в массиве = {count}");
