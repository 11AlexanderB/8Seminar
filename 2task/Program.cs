int[,] FillMatrix(int rows, int columns)
{
    int[,] Matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return Matrix;
}

void PrintMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void LineMinSum(int[,] Matrix)
{
    int MinSum = 0;
    int Row = 0;
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        int SumLine = 0;

        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            SumLine += Matrix[i, j];
        }
        if (MinSum == 0)
        {
            MinSum = SumLine;
            Row = i;
        }
        else if (SumLine < MinSum)
        {
            MinSum = SumLine;
            Row = i;
        }
    }
    Console.WriteLine($"Минимальная сумма в строке c индексом номер:{Row}");
}

try
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] Matrix = FillMatrix(m, n);
    Console.WriteLine("Вывод массива на экран: ");
    PrintMatrix(Matrix);
    Console.WriteLine();
    LineMinSum(Matrix);
}
catch
{
    Console.WriteLine("Ошибка");
}