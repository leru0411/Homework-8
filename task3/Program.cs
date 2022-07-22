//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Одну матрицу можно умножать на другую только тогда,
// когда количество столбцов в первой матрице совпадает с количеством строк во второй матрице.
// То есть, матрицы должны быть согласованы по размерности.
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}
int[,] MatrixMultiple(int[,] array1, int[,] array2)
{
    int[,] matrix = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            matrix[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                matrix[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return matrix;
}

int rows = Prompt("Введите количество строк > ");
int columns = Prompt("введите количество столбцов > ");

int[,] firstArray = GenerateArray(rows, columns, 1, 5);
int[,] secondArray = GenerateArray(columns, rows, 1, 5);
PrintArray(firstArray);
PrintArray(secondArray);
int[,] finalArray = MatrixMultiple(firstArray, secondArray);
PrintArray(finalArray);