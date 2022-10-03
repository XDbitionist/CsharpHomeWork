/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */
Console.Clear();
Console.WriteLine("Введите 2 числа, чтобы определить максимальное: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine());
if (number > num)
{
    Console.Write("MAX: ");
    Console.Write(number);
}
if (number < num)
{
     Console.Write("MAX: ");
    Console.Write(num);
}