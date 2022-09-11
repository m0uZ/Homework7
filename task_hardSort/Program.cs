// Задача HARD SORT. Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:     После сортировки:
// 1 4 7 2                     1 2 3 4
// 5 9 10 3                    5 7 9 10

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int m, int n)

{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(1, 100);
    }
    return array;
}

int FindMin(int[,] array)
{
    int min = array[0, 0];
    foreach (int item in array)
    {
        if (min > item) min = item;
    }
    return min;
}
int FindMax(int[,] array)
{
    int max = array[0, 0];
    foreach (int item in array)
    {
        if (max < item) max = item;
    }
    return max;
}
int[,] SortArray(int[,] array)
{
    int[,] mas = new int[array.GetLength(0), array.GetLength(1)];
    int max = FindMax(array);
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = FindMin(array);
            for (int f = 0; f < array.GetLength(0); f++)
            {
                for (int h = 0; h < array.GetLength(1); h++)
                {
                    if (mas[i, j] == array[f, h])
                    {
                        array[f, h] = max;
                    }
                }
            }
        }
    }
    return mas;
}
Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas = FillArray(m, n);
PrintArray(mas);
Console.WriteLine();
PrintArray(SortArray(mas));
