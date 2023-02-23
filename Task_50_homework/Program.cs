/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента
в массиве нет
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


int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
Console.WriteLine("Введите позицию элемента массива по вертикали: ");
int row = Convert.ToInt32(Console.ReadLine());
if (row > array2D.GetLength(0)) Console.WriteLine("Значение превышает кол-во строк!");

Console.WriteLine("Введите позицию элемента массива по горизонтали: ");
int col = Convert.ToInt32(Console.ReadLine());
if (col > array2D.GetLength(1)) Console.WriteLine("Значение превышает кол-во столбцов!");

if (row <= array2D.GetLength(0) && col <= array2D.GetLength(1))
    Console.WriteLine($"Значение выбранной ячейки массива: {array2D[row-1, col-1]}");

