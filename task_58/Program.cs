// Напишите программу, которая заполнит спирально массив 4 на 4.

void Zadacha58()
{
    int rows = 4;
    int colums = 4;

    Console.WriteLine($"Массив размера {rows}x{colums}");
    int[,] number = new int[rows, colums];

    FillArray(number);
    PrintArray(number);
}

void FillArray(int[,] number)
{
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);
    int num = rows * colums;
    for(int i = 0; i < num; i++)
    {
        if(i < 4)
            number[0, i] = i + 1;
        if(i > 3 && i < 5)
            number[1, 3] = i + 1;
        if(i > 4 && i < 6)
            number[2, 3] = i + 1;
        if(i > 5 && i < 7)
            number[3, 3] = i + 1;
        if(i > 6 && i < 8)
            number[3, 2] = i + 1;
        if(i > 7 && i < 9)
            number[3, 1] = i + 1;
        if(i > 8 && i < 10)
            number[3, 0] = i + 1;
        if(i > 9 && i < 11)
            number[2, 0] = i + 1;
        if(i > 10 && i < 12)
            number[1, 0] = i + 1;
        if(i > 11 && i < 13)
            number[1, 1] = i + 1;
        if(i > 12 && i < 14)
            number[1, 2] = i + 1;
        if(i > 13 && i < 15)
            number[2, 2] = i + 1;
        if(i > 14 && i < 16)
            number[2, 1] = i + 1;
    }
}

void PrintArray(int[,] number)
{
    Console.WriteLine();
    Console.WriteLine("Исходный массив: ");
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

Zadacha58();