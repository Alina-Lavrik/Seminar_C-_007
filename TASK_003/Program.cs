// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


int rows = new Random().Next(5, 6);
int columns = new Random().Next(5, 6);
Console.WriteLine($"Получили строк - {rows}");
Console.WriteLine($"Получили столбцов - {columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

int SumNum = NewGetArray(array);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали массива - {SumNum}");


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

int NewGetArray(int[,] array)                // функция поиска по диагонали
{
    int Sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (i == j)
           {
            Sum = array[i , j] + Sum;
           }
        }
    }
    return Sum;
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

