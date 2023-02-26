// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.WriteLine();
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");

int [,] pascal = new int [m+1, 2*m+1];
for (int z = 0; z < pascal.GetLength(0); z++)
{
    pascal[z, 0] = 1;
}
for (int i = 1; i < pascal.GetLength(0); i++)
{
    for (int j = 1; j < i+1; j++)
    {
        pascal[i, j] = pascal[i-1, j] + pascal[i-1, j-1];
    }
}

Console.WriteLine("Треугольник Паскаля");
for (int i = 0; i < pascal.GetLength(0); i++)
{
    for (int j = 0; j < pascal.GetLength(1); j++)
    {
        if (pascal[i, j] != 0)
        {
            Console.Write($"{pascal[i, j]} ");
        }
        else Console.Write("  ");
    }
    Console.WriteLine();
}

for (int i = 0; i < pascal.GetLength(0); i++)
{
    int count = 0;
    for (int j = pascal.GetLength(1) - 1; j >= 0; j--)
    {
        if (pascal[i, j] != 0)
        {
            pascal[i, pascal.GetLength(1) / 2 + j - count] = pascal[i, j];
            pascal[i, j] = 0;
            count++;
        }
    }
}
pascal[pascal.GetLength(0) - 1, 0] = 1;

Console.WriteLine("Вывод в виде равнобедренного треугольника");
for (int i = 0; i < pascal.GetLength(0); i++)
{
    for (int j = 0; j < pascal.GetLength(1); j++)
    {
        if (pascal[i, j] != 0)
        {
            Console.Write($"{pascal[i, j]} ");
        }
        else Console.Write("  ");
    }
    Console.WriteLine();
}
Console.WriteLine();

