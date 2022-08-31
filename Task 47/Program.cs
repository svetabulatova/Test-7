﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double [,]FillMatrix(int rowsCount,int columnsCount, double leftRange=-10,double rightRange=10)
{
    double [,] matrixToPopulate=new double[rowsCount,columnsCount];
    Random rand=new Random();
    for(int i=0;i<matrixToPopulate.GetLength(0);i++)
    {
        for (int j=0; j<matrixToPopulate.GetLength(1);j++)
        {
            matrixToPopulate[i,j]=rand.NextDouble()*(rightRange-leftRange)+leftRange;
        }
    }
    return matrixToPopulate;
}
void PrintMatrix(double[,]matrixToPrint)
{
    for(int i=0;i<matrixToPrint.GetLength(0);i++)
    {
        for(int j=0;j<matrixToPrint.GetLength(1);j++)
        {
            Console.Write($"{matrixToPrint[i,j]:f2}");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите m");
int m=Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите n");
int n=Convert.ToInt32 (Console.ReadLine());
double[,] newMatrix=FillMatrix(m,n);
PrintMatrix(newMatrix);