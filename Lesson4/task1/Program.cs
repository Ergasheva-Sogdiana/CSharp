﻿int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            matrix[i, j] = random.Next(1, 10);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        Console.WriteLine("\n");
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    }
}

int [,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);


