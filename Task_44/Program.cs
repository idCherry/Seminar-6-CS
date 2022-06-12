// Не используя рекурсию, выведите N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


Console.WriteLine("Введите ограничение кол-ва цифр Фибоначчи: ");
int number = int.Parse(Console.ReadLine());
int a = 0;
int b = 1;
Console.Write(a + " " + b + " ");
int sum = 0;

for (int i = 0; i < number - 2; i++)
{
    sum = a + b;
    Console.Write(sum + " ");
    a = b;
    b = sum;
}