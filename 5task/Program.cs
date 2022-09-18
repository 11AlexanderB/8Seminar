int[,] FillMatrix(int Row, int Col)
{
    int[,] Matrix = new int[Row, Col];
    int Number = 1; // Начальный элемент.
    int Frame = 0; //Вспомогательная переменная, которая определяет какую рамку мы заполняем.

    for (Frame = 0; Number <= Row * Col; Frame++)
    {
        for (int i = 0 + Frame; i < Col - Frame; i++)
        {
            Matrix[0 + Frame, i] = Number;
            Number++;
        }
        Number--;
        for (int i = 0 + Frame; i < Row - Frame; i++)
        {
            Matrix[i, (Col - 1) - Frame] = Number;
            Number++;
        }
        Number--;
        for (int i = (Col - 1) - Frame; i >= 0 + Frame; i--)
        {
            Matrix[(Row - 1) - Frame, i] = Number;
            Number++;
        }
        Number--;
        for (int i = (Row - 1) - Frame; i > 0 + Frame; i--)
        {
            Matrix[i, 0 + Frame] = Number;
            Number++;
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
            Console.Write($"{table[i, j]}     ");
        }
        Console.WriteLine();
    }
}

try
{
    Console.WriteLine();
    Console.WriteLine("Внимание! Количество строк и столбцов должно совпадать! ");
    Console.WriteLine();

    Console.Write("Введите количество строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m == n)
    {
        int[,] Matrix = FillMatrix(m, n);
        PrintMatrix(Matrix);
    }
    else Console.WriteLine("Ошибка");
}
catch
{
    Console.WriteLine("Ошибка");
}
