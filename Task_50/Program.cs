// Программа, которая на вход принимает позиции
// элемента в двумерном массиве и возвращает
// значение этого элемента или же указание, что такого элемента нет.

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

Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
if (row >=0 && row <m && column >=0 && column <n) 
{
    Console.WriteLine($"Элемент массива равен {matrix[row, column]}");
}
else Console.WriteLine("Такого элемента нет");