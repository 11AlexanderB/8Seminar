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

int[,] DescendingRows(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1) - 1; j++)
        {
            int MaxValue = Matrix[i, j];
            for (int k = j + 1; k < Matrix.GetLength(1); k++)
            {
                if (Matrix[i, k] > MaxValue)
                {
                    MaxValue = Matrix[i, k];
                    int temp = Matrix[i, j];
                    Matrix[i, j] = Matrix[i, k];
                    Matrix[i, k] = temp;
                }
            }
        }
    }
    return Matrix;
}

try
{
    Console.WriteLine("Введите количество строк: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int[,] Matrix = FillMatrix(m, n);
    Console.WriteLine("Вывод массива на экран: ");
    PrintMatrix(Matrix);
    Console.WriteLine("Вывод отсортированого массива: ");
    PrintMatrix(DescendingRows(Matrix));
}
catch
{
    Console.WriteLine("Ошибка");
}