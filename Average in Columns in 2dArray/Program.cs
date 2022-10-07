// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();
int[,] userArray = Create2dArray(3, 4);
Print2dArray(userArray);
WriteLine();
AverageIn2dArrayColumns(userArray);



void AverageIn2dArrayColumns(int[,] analysedArray)
{
    double average = 0;
    for (int i = 0; i < analysedArray.GetLength(1); i++)
    {
        for (int j = 0; j < analysedArray.GetLength(0); j++)
        {
            average += analysedArray[j, i];
        }
        Write($"{Math.Round(average/(analysedArray.GetLength(0)),1)}\t");
        average = 0;
    }
}



int[,] Create2dArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = rnd.Next(0, 10);
        }

    }
    return newArray;
}

void Print2dArray(int[,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Write($"{printedArray[i, j]}\t");
        }
        WriteLine();
    }
}