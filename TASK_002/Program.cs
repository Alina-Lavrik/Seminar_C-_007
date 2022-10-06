// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int rows = new Random().Next(3, 7);
int columns = new Random().Next(4, 8);
Console.WriteLine($"Получили строк - {rows}");
Console.WriteLine($"Получили столбцов - {columns}");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine($"Новый массив с элементами в квардате");
int[,] array1 = NewGetArray(array);
PrintArray(array1);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[,] NewGetArray(int[,] result)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if((i % 2 ==0) && (j % 2 ==0))
           {
            result[i , j] = result[i , j] * result[i , j];
           }
        }
    }
    return result;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}



