int[,] CreateMatrix(int rows, int columns, int min, int max)  // создание двухмерного массива
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max); 
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)        // вывод двухмерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] EvenIndSquare(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if( i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
    }
    return matrix;
}

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, columns, min, max);
PrintMatrix(matrix);
PrintMatrix(EvenIndSquare(matrix));
// PrintMatrix(CreateMatrix(rows,columns,min,max));

// PrintMatrix(CreateMatrix(4, 9, 1, 9));

