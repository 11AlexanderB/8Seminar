int[,,] FillMatrix(int page, int row, int col)
{
    int[,,] Matrix = new int[page, row, col];

    for (int i = 0; i < page; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                Matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return Matrix;
}

void PrintMatrix(int[,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int k = 0; k < table.GetLength(2); k++)
            {
                Console.Write($"{table[i, j, k]}=({i}, {j}, {k})  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

try
{
    Console.Write("Введите кординату page: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кординату row: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кординату col: ");
    int z = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,,] Matrix = FillMatrix(x, y, z);
    PrintMatrix(Matrix);
}

catch
{
    Console.Write("Ошибка");
}
