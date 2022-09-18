int[,] FillFirstMatrix(int rows, int columns)
{
    int[,] FirstMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            FirstMatrix[i, j] = new Random().Next(1, 10);
        }
    }
    return FirstMatrix;
}

int[,] FillSecondMatrix(int rows, int columns)
{
    int[,] SecondMatrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            SecondMatrix[i, j] = new Random().Next(1, 10);
        }
    }
    return SecondMatrix;
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

int[,] MatrixProduct(int[,] table, int[,] table1)
{
    int m = table.GetLength(0);
    int n = table1.GetLength(1);
    int[,] ResultMatrix = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            ResultMatrix[i, j] = 0;
            for (int k = 0; k < table.GetLength(1); k++)
            {
                ResultMatrix[i, j] += table[i, k] * table1[k, j];
            }
        }
    }
    return ResultMatrix;
}

try
{
    Console.WriteLine();
    Console.WriteLine("Внимание! Кол-во столбцов первой матрицы должно совпадать с кол-вом строк второй матрицы! ");
    Console.WriteLine();

    Console.Write("Введите количество строк первой матрицы: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов первой матрицы: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Первая матрица: ");
    int[,] FirstMatrix = FillFirstMatrix(m, n);
    PrintMatrix(FirstMatrix);
    Console.WriteLine();

    Console.Write("Введите количество строк второй матрицы: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов второй матрицы: ");
    int l = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Вторая матрица: ");
    int[,] SecondMatrix = FillSecondMatrix(k, l);
    PrintMatrix(SecondMatrix);
    Console.WriteLine();

    if (n == k)
    {
        Console.WriteLine("Произведение двух матриц: ");
        PrintMatrix(MatrixProduct(FirstMatrix, SecondMatrix));
    }
    else Console.WriteLine("Ошибка");
}
catch
{
    Console.WriteLine("Ошибка");
}