//Задайте двумерный массив. Напишите программу, которая 
//упорядочит по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Random random = new Random();
    int rows = 5;
    int colums = 5;

    Console.WriteLine($"Массив размера {rows}x{colums}");
    int[,] number = new int[rows, colums];
    int[,] sorting_number = new int[rows, colums];

    FillArray(number, sorting_number, rows, colums);
    Sorting(sorting_number, rows, colums);
    PrintArray(number, rows, colums);
    SortingPrintArray(sorting_number, rows, colums);
}

void FillArray(int[,] number, int[,] sorting_number, int rows, int colums)
{
    Random random = new Random();
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            number[i, j] = random.Next(-9, 10);
            sorting_number[i, j] = number[i, j];
        }
    }

}
void Sorting(int[,] sorting_number, 
             int rows, int colums)
{
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
void PrintArray(int[,] number, int rows, int colums)
{
    Console.WriteLine();
    Console.WriteLine("Исходный массив: ");
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            Console.Write($"{number[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortingPrintArray(int[,] sorting_number, int rows, int colums)
{
    Console.WriteLine("Сортировка исходного массива: ");
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < rows; j++)
        {
            Console.Write($"{sorting_number[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Zadacha54();