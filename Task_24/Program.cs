// Задача 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 8 -> 10
// 4 -> 36

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= number; i++)
{
    sum = sum + i;
}

System.Console.WriteLine($"Сумма чисел от 1 дл {number}: {sum}");