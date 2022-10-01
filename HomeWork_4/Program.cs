
#region Task25 
/// <summary>
///на вход два натуральных числа (A и B) и возводит число A в степень B.
/// </summary>

void Task25()
{
    Console.WriteLine("Введите 1-е число: ");
    Console.Write("А =  ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите 2-е число: ");
    Console.Write("B = ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = a * i;
    }
    Console.WriteLine("Число А в степени В = " + result);
}
#endregion

#region Task27
/// <summary>
///принимает на вход число и выдаёт сумму цифр в числе.
/// </summary>
void Task27()
{
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int current = Math.Abs(number);
        
        int sum = 0;
        int a = NumberDigits(current);
        for (int i = 0; i < a; i++)
        {
            sum = sum + current % 10;
            current = current / 10;            
        }
        Console.WriteLine($"Сумма цифр в числе {number} = {sum}");
    }
}

//int GetCountNumbers(int number)
//{

//    return number.ToString().Length;
//}


int NumberDigits(int current) // считает количество цифр в числе
{
        int i = 0;

        while (current > 0)
        {          
        current /= 10;
           i++;        
        }
    return i;
}



#endregion
//Task25();
Task27();