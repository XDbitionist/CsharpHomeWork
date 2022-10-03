/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */
Console.Clear();
Console.WriteLine("Введите число, чтобы показать все четные числа до заданного числа: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
Console.WriteLine("Четные: ");
if (index == 1)
{
    index++;
}
while (index <= number)
{
    Console.WriteLine(index);
    index += 2;
}
