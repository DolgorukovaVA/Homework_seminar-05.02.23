// Составить частотный словарь элементов двумерного массива
int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

int[,] InitRandomMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[] TurnMatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}

void PrintUniqEl(int[] array)
{
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine(array[i-1] + " встречается " + count + " раз");
            count = 1;
        }
    }
    Console.WriteLine(array[array.Length-1] + " встречается " + count + " раз");
}
int lines = GetNumber("Введите кол-во строк: ");
int rows = GetNumber("Введите кол-во столбцов: ");

int[,] matrix = InitRandomMatrix(lines, rows);
PrintMatrix(matrix);
Console.WriteLine();

int[] array = TurnMatrixToArray(matrix);
PrintArray(array);
Console.WriteLine();

Array.Sort(array);
PrintArray(array);
Console.WriteLine();

PrintUniqEl(array);

