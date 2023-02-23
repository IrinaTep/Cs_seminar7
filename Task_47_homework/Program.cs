/*
Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
*/


// Метод для создания двухмерного массива
double[,] CreateMatrixRndDouble(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = Math.Round(rnd.NextDouble(), 2);
        }
    }
    return matrix;
}

// Метод для выведения двухмерного массива
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5} |");
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2D = CreateMatrixRndDouble(3, 4, -100.0, 100.0);
PrintMatrix(array2D);