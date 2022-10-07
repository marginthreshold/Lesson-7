//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using static System.Console;
Clear();

WriteLine("Введите размеры, минимальное и максимальне значения двумерного массива через пробел: ");
string[] userparameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] arrayparameters = ParseStringArrayToInt(userparameters);
double[,] userarray=CreateDoubleArrayByParameters(arrayparameters);
PrintTwoDimentionalArray(userarray);



int[] ParseStringArrayToInt(string[] array)
{
    int[] newarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newarray[i] = Convert.ToInt32(array[i]);
    }
    return newarray;
}

double[,] CreateDoubleArrayByParameters(int[] userParam)
{
    double[,] doubleArray = new double[userParam[0], userParam[1]];
    Random rnd = new Random();
    
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            doubleArray[i,j] =Math.Round(userParam[2] + rnd.NextDouble() * (userParam[3] - userParam[2]),1);
        }
    }
    return doubleArray;
}

void PrintTwoDimentionalArray(double[,] printedArray)
{
    for (int i = 0; i < printedArray.GetLength(0); i++)
    {
        for (int j = 0; j < printedArray.GetLength(1); j++)
        {
            Write($"{printedArray[i,j]}\t");
        }
        WriteLine();
    }
}
