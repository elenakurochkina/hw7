// Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами

int Prompt(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateArray(int m, int n)
{
    var array = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 100;
              }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F3}" + "\t");
        }
        System.Console.WriteLine();
    }
}

int m = Prompt("count of ms: ");
int n = Prompt("count of ns: ");
double[,] array = GenerateArray(m, n);
PrintArray(array);