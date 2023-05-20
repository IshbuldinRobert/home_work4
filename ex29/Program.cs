// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] mass = new int[8];

void FillArr(int[] fillArr)
{
    for (int i = 0; i < fillArr.Length; i++)
    {
        fillArr[i] = new Random().Next(10, 100);
    }
}

void PrintArr(int[] printArr)
{
    Console.Write("[");
    for (int i = 0; i < printArr.Length; i++)
    {
        if (i == printArr.Length - 1) Console.WriteLine($"{printArr[i]}]");
        else Console.Write($"{printArr[i]}, ");
    }
}

FillArr(mass);
PrintArr(mass);