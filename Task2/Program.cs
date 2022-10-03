/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.Clear();
int a = -9;
int b = -3;
if (a > b)
{
    Console.Write("max = ");
    Console.Write(a);
}
if (a < b)
{
    Console.Write("max = ");
    Console.Write(b);
}