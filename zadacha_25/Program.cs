// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
//  число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Number(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

int num1 = Number("Введите число А: ");
int num2 = Number("Введите число B: ");

int Stepen(int B)
{
    int result = num1;
    int count = 2;
    for (int i = num1; count <= num2; count++)
    {

        result = result * i;
    }

return result;
}

System.Console.WriteLine($"{num1}^{num2} = {Stepen(num2)}");

