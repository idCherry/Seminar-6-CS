// Напишите программу, которая будет создавать копию массива с помощью поэлементного копирования.

Console.Write("Ваедите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];
int[] newArray = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-50, 50);
}

for (int i = 0; i < size; i++)
{
    newArray[i] = array[i];
}

Console.WriteLine($"{string.Join(' ', array)}");
Console.WriteLine($"{string.Join(' ', newArray)}");