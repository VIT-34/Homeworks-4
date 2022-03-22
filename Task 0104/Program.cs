
int a, b;
int pow = 1;
Console.Write("Введите число: ");
a = Int32.Parse(Console.ReadLine());
Console.Write("введите стпень числа: ");
b = Int32.Parse(Console.ReadLine());


for (int i = 0; i < b; i++)
{
    pow *= a;
}
Console.WriteLine($"Степень числа {pow}");
return 0;



