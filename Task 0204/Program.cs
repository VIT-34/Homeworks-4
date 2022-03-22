// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int a, b;

Console.Write("Введите число: ");
a = Int32.Parse(Console.ReadLine());

int sum = 0;
while (a !=0)
{
    b = a % 10;
    a = a / 10;
    sum = sum +b;
}
Console.Write("Сумма цифр: " +sum);
