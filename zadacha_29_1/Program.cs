// Напишите программу, которая задаёт массив из 8 элементов и выводит
//  их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i] + "; "}");
    }
}
int[] Mass()
{
    int[] MassivN = new int[8];
    for (int i = 0; i < 8; i++)
    {
        MassivN[i] = new Random().Next(0,20);        
    }
    return MassivN;
}
int[] MyMass  = Mass();
PrintArray(MyMass);
