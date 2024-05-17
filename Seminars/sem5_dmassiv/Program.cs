// Задание 1. Совместная работа
// Семинар 5. Двумерные массивы
// 15 мин
// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.

int [,] CreatMatrix(int rows, int colums,int min,int max)  //Создание Двухмерного массива
{
    int[,]matrix = new int [rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++) 
            matrix[i, j] = rnd.Next(min, max);
    return matrix;
}

void PrintMatrix(int [,] matrix)  //Вывод на экран Двухмерного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

int [,] EvenIndexSquare(int [,] matrix)  //возведение в квадрат число с четным индексом
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
                matrix[i, j] = matrix[i, j] * matrix[i, j];
     return matrix;
}

// PrintMatrix(ChangeElements(CreatMatrix(5, 5, 0, 10)));
System.Console.WriteLine("Input number of rows: ");    //ввод данных
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of colums: ");  //ввод данных
int colums = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");  //ввод данных
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: "); //ввод данных
int max = Convert.ToInt32(Console.ReadLine());

int [,] matrix = CreatMatrix(rows, colums, min, max);  // Создание матрицы с помощю функции
PrintMatrix(matrix);                         // Вывод на экран матрицы с помощю функции
Console.WriteLine();
// matrix = EvenIndexSquare(matrix);
// PrintMatrix(matrix);

PrintMatrix(EvenIndexSquare(matrix));   // изменение матрицы и вывод на экран
// PrintMatrix(EvenIndexSquare(CreatMatrix(rows, colums, min, max)));
// PrintMatrix(EvenIndexSquare());

// Console.WriteLine(matrix[3,3]);