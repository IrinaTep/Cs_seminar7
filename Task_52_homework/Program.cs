/*
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.
*/

// Метод для создания двухмерного массива
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             matrix[i, j] = rnd.Next(min, max +1);
        }
    }
    return matrix;
}

// Метод для выведения двухмерного массива
void PrintMatrix(int[,] matrix)
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

double[] ArithmeticAverage (int[,] matrix)
{
    double[] arithAverage = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double colSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            colSum += matrix[i, j];
        }
        arithAverage[j] = Math.Round(colSum / matrix.GetLength(0),2); 
    }
    return arithAverage;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        //array[i] = rnd.Next(min, max + 1);
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}


int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
PrintArray(ArithmeticAverage(array2D));