//  Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

Console.WriteLine("Задайте двумерный массив m x n");
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int j = 0; j < n; j++)
{
    double sum = 0;
    for (int i = 0; i < m; i++)
    {
        sum = sum + matrix[i, j];
    }
    double average = sum / m;
    Console.WriteLine($"Среднее арифметическое {j + 1}-го столбца = {average}");
}

