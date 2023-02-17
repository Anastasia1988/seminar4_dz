// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и
//  выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]}");
    }
}
int[] Mass()
{
    int[] MassivN = new int[8];
    // var MyRandom = new Random();
    // int result = 0;
    for (int i = 0; i < 8; i++)
    {
        MassivN[i] = new Random().Next(1, 0);        
    }
    return MassivN;
}
int[] MyMass  = Mass();
PrintArray(MyMass);
// int[] myMass1 = Massiv(8);
// // int[] count = Massiv(8);
// // int[] Mass2 = Fillarray(3);
// PrintMassiv(myMass1);
// // PrintMassiv(Mass2);
