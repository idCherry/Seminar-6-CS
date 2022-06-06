// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Ведите целое число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Ведите систему счисления: ");
int baseNum = int.Parse(Console.ReadLine());

// int result = 0;
// int d10 = 1;

// while (num != 0)
// {
//     result = result + num % baseNum * d10;
//     num /= baseNum;
//     d10 *= 10;
// }
// Console.WriteLine(result);

void DecToOther(int n, int baseN)
{
    if (n == 0) return;
    DecToOther (n / baseN, baseN);
    Console.Write(n % baseN);
}
DecToOther(num, baseNum);