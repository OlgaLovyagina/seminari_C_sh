// Напишите программу, которая на вход принимает два числа и проверяет,
//является ли первое число квадратом второго.
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;
if (a == c)
{   
    Console. WriteLine("Да, первое число является квадратом второго");
}
else
{
    Console. WriteLine("Нет, первое число не является квадратом второго");
}
