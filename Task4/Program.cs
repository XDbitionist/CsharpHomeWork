/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.Clear();
Console.WriteLine("Введите 3 числа, чтобы определить максимальное: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Convert.ToInt32(Console.ReadLine());
int max = number;

if (number > max) max = number;
if (num > max) max = num;
if (num1 > max) max = num1;

Console.Write("max = ");
Console.WriteLine(max);
