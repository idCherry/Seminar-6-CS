// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

Console.Write("Введите целые числа через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int index1 = 0;
int index2 = array.Length - 1;

while (index1 < index2)
{
    int temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp; 

    index1++;
    index2--;
}

Console.Write($"{String.Join(" ", array)}");


