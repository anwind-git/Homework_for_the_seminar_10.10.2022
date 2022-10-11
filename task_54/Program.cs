// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Random random = new Random();
    int rows = random.Next(4, 9);
    int colums = random.Next(4, 9);

    Console.WriteLine($"Массив размера {rows}x{colums}");
    int[,] number = new int[rows, colums];
    int[,] sorting_number = new int[number.GetLength(0), number.GetLength(1)];

    FillArray(number, sorting_number);
    Sorting(number, sorting_number);
    PrintArray(number);
    SortingPrintArray(number, sorting_number);
}

void FillArray(int[,] number, int[,] sorting_number)
{
    Random random = new Random();
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);
    
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            number[i, j] = random.Next(-9, 10);
            sorting_number[i, j] = number[i, j];
        }
    }

}

void Sorting(int[,] number, int[,] sorting_number)
{
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            for(int k = 0; k < colums; k++)
            {
                if(sorting_number[i, j] > sorting_number[i, k])
                {
                    int temp = sorting_number[i, j];
                    sorting_number[i, j] = sorting_number[i, k];
                    sorting_number[i, k] = temp;
                }
            }
        }
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

void SortingPrintArray(int[,] number, int[,] sorting_number)
{
    Console.WriteLine("Сортировка исходного массива: ");
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
        {
            Console.Write($"{sorting_number[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Zadacha54();