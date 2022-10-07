// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
using static System.Console;
Clear();


int[,] userArray = CreateRandom2dArray(3, 4, 0, 10);
Print2dArray(userArray);

WriteLine("Введите номер строки и номер столбца элемента массива через пробел: ");
string[] paramters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

FindElementIn2dArray(paramters,userArray);

void FindElementIn2dArray(string[] elements, int[,] analysedArray)
{
    int i =Convert.ToInt32(elements[0]);
    int j=Convert.ToInt32(elements[1]);
    try
    {
        WriteLine($"{analysedArray[i-1,j-1]}");
    }
    catch (System.Exception)
    {
        WriteLine($"Такого элемента нет");
    }
    
}




int[,] CreateRandom2dArray(int rows, int columns, int minRandom, int maxRandom)
{
    int[,] newArray = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = rnd.Next(minRandom, maxRandom + 1);
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