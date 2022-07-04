//Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int row, int column, int min, int max)
{
    var array = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

double[] AveragePerColumnArray(int[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++) sum += array[i, j];
        arr[j] = sum / array.GetLength(0);
    }
    return arr;
}

void PrintArr(double[] arr)
{
    foreach (double element in arr)
    {
        System.Console.WriteLine($"{element}; ");
    }
    System.Console.WriteLine();
}

int row = 2;
int column = 2;
int min = 0;
int max = 5;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
double[] arr = AveragePerColumnArray(array);
PrintArr(arr);






