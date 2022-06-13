// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите элементы массива через пробел: ");
int [] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int count = 0;

Console.WriteLine();

for (int i = 0; i < numsArr.Length; i++)
{
    if (numsArr[i] > 0) count += 1;
}

Console.WriteLine($"Количество чисел больше нуля в массиве = {count}");
