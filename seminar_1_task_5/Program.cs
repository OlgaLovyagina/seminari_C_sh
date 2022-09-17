// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//Здесь используеся каскад "если", чтобы программа работала более эффективно
Console.Write("введите целое положительное число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine()); 
if (day == 1)
{
    Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    Console.WriteLine("Вторник");
}
else if (day == 3)
{
    Console.WriteLine("Среда");
}
else if (day == 4)
{
    Console.WriteLine("Четверг");
}
else if (day == 5)
{
    Console.WriteLine("Пятница");
}
else if (day == 6)
{
    Console.WriteLine("Суббота");
}
else if (day == 7)
{
    Console.WriteLine("Воскресенье");
}
else 
{
    Console.WriteLine("Неверный ввод, нужно было ввести целое число от 1 до 7");
}