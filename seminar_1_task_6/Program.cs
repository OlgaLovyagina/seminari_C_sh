// 5. Напишите программу вычисления значения функции возведения числа в квадрат.
int Power(int x)
{
    return x*x;
}
Console.WriteLine("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(namber));


