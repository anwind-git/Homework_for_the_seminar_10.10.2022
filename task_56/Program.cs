//Задайте прямоугольный двумерный массив. Напишите 
//программу, которая будет находить строку с наименьшей суммой элементов.

void Zadacha56()
{
    int rows = 4;
    int colums = 5;

    Console.WriteLine($"Массив размера {rows}x{colums}");
    int[,] number = new int[rows, colums];
    int[] sum_number = new int[number.GetLength(0)];

    FillArray(number);
    PrintArray(number);
    NumSum(number, sum_number);
    MinArray(sum_number);
}

void FillArray(int[,] number)
{
    Random random = new Random();
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            number[i, j] = random.Next(0, 10);
        }
    }

}

void PrintArray(int[,] number)
{
    Console.WriteLine();
    Console.WriteLine("Массив случайных чисел: ");
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write(number[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void NumSum(int[,] number, int[] sum_number)
{
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int num = 0;
        for (int j = 0; j < colums; j++)
        {
            num += number[i, j];
            sum_number[i] = num;
        }
        Console.WriteLine($"Сумма чисел строки {i+1} ровна: {sum_number[i]}");
    }
    Console.WriteLine();
}
void MinArray(int[] sum_number)
{
    int min = sum_number[0];
    int index = 0;
    for (int i = 0; i < sum_number.Length; i++)
    {
        if (min >= sum_number[i])
        {
            min = sum_number[i];
            index = i + 1;
        }
    }
    Console.WriteLine($"У строки {index} наименьшая сумма элементов");
    Console.WriteLine();
}
Zadacha56();