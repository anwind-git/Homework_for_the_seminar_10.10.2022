//Напишите программу, которая заполнит спирально массив 4 на 4.

void Zadacha58()
{
    Random random = new Random();
    int rows = random.Next(3, 9);
    int colums = random.Next(3, 9);

    Console.WriteLine($"Массив размера {rows}x{colums}");
    int[,] number = new int[rows, colums];

    FillArray(number);
    PrintArray(number);
}

void FillArray(int[,] number)
{
    int rows = number.GetLength(0);
    int colums = number.GetLength(1);
    int index = 0;
    int currentRow = 0;
    int currentColumn = 0;

    int chengIndexRow = 0;
    int chengIndexColumn = 1;

    int steps = colums;
    int turn = 0;
    
    while(index < number.Length)
    {
        number[currentRow, currentColumn] = index + 1;
        index++;
        steps--;
        if(steps == 0)
        {
            steps = rows * ((turn+1)%2) + colums * (turn%2)- 1 - turn/2;
            int temp = chengIndexRow;
            chengIndexRow = chengIndexColumn;
            chengIndexColumn = - temp;
            turn++;

        }
        currentRow += chengIndexRow;
        currentColumn += chengIndexColumn;

    }
}

void PrintArray(int[,] number)
{
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