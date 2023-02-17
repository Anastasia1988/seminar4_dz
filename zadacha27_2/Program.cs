// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Number(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNum(int a)
{
    
    int sum = 0;
    for(int i = a; i > 0; i++)
    {
        sum = sum + (a % 10);
        a = a / 10;
    }
    return sum;
}
int num = Number("Введите число: ");
System.Console.WriteLine($"Сумма цифр числа {num} равна {SumNum(num)}");

