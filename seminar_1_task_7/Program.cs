// 7. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console. ReadLine());
num = Math.Abs(num); // используем модуль, так как введенное число может быть отрицательное
int nam1 = -num;
while(nam1 <= num)
{
    Console.Write(nam1 + "  ");
    nam1 = nam1 + 1;
}
Console.WriteLine();

