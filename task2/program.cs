//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же 
//указание, что такого элемента нет

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

int FoundElement(int[,] array, int rowPosition, int columnPosition)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            if (i == rowPosition && j == columnPosition) return array[rowPosition, columnPosition];
        }
    }
    return -1;
}
int row = 5;
int column = 5;
int min = -10;
int max = 10;
int[,] array = GenerateArray(row, column, min, max);
PrintArray(array);
System.Console.WriteLine();

int rowPosition = Prompt("row position: ");
int columnPosition = Prompt("column position: ");
int foundElement = FoundElement(array, rowPosition, columnPosition);
if (rowPosition < 0 || rowPosition > array.GetLength(0) || columnPosition < 0 || columnPosition > array.GetLength(0)) System.Console.WriteLine("no element");
else System.Console.WriteLine($"element is {array[rowPosition, columnPosition]}");


