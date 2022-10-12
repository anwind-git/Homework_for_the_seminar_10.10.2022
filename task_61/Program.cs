// Задайте две матрицы. Напишите 
// программу, которая будет находить произведение 
// двух матриц.

void Zadacha61()
{
    int rows = 5;
    int colums = 5;

    Console.WriteLine($"Массив размера {rows}x{colums}");
    int[,] number1 = new int[rows, colums];
    int[,] number2 = new int[number1.GetLength(0), number1.GetLength(1)];
    int[,] number3 = new int[number1.GetLength(0), number1.GetLength(1)];

    FillArray(number1, number2);
    Composition(number1, number2, number3);
    PrintMatrica1(number1);
    PrintMatrica2(number1, number2);
    PrintComposition(number1, number3);
}

void FillArray(int[,] number1, int[,] number2)
{
    Random random = new Random();
    int rows = number1.GetLength(0);
    int colums = number1.GetLength(1);
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            number1[i, j] = random.Next(0, 10);
            number2[i, j] = random.Next(0, 10);
        }
    }

}

void Composition(int[,] number1, int[,] number2, int[,] number3)
{
    int rows = number1.GetLength(0);
    int colums = number1.GetLength(1);
    int col = rows * colums;
    int summa = 0;
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            for(int k = 0; k < colums; k++)
            {
                summa = summa + (number1[i, k] * number2[k, j]);
                number3[i, j] = summa;
            }
            summa = 0;
        }
    }
}

void PrintMatrica1(int[,] number1)
{
    Console.WriteLine();
    Console.WriteLine("Матрица 1: ");
    int rows = number1.GetLength(0);
    int colums = number1.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write(number1[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintMatrica2(int[,] number1, int[,] number2)
{
    Console.WriteLine("Матрица 2: ");
    int rows = number1.GetLength(0);
    int colums = number1.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write($"{number2[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintComposition(int[,] number1, int[,] number3)
{
    Console.WriteLine("Произведение двух матриц: ");
    int rows = number1.GetLength(0);
    int colums = number1.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write($"{number3[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Zadacha61();