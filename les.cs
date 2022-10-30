//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

/*Console.WriteLine("Bведите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bведите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[m, n];
Order(table);
Console.WriteLine();
PrintArray(table);

void Order(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        for (int z = 0; z < n - 1; z++)
        {
            if (table[i, z] < table[i, z + 1]) 
            {
                int temp = 0;
                temp = table[i, z];
                table[i, z] = table[i, z + 1];
                table[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(table);
*/



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
//будет находить строку с наименьшей суммой элементов.

/*Console.Write("Bведите количество строк:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Bведите количество столбцов:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] table = new int[m, n];
int minsum = Int32.MaxValue;
int index = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        table[i, j] = new Random().Next(0, 10);
        Console.Write(table[i, j] + " ");
    }
    Console.WriteLine();
}
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum = sum + table[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        index++;
    }
}
Console.WriteLine("Строка с наименьшей суммой № " + (index) + ",  сумма элементов : " + (minsum));
*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/*Console.Write("Введите размер квадратных матриц: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, m];
int[,] matrix2 = new int[m, m];
MatrixArray(matrix1);
MatrixArray(matrix2);
int[,] matrix3 = new int[m, m];

void MatrixArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(1, 5); 
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("  ");
    }
}
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < m; k++)
        {
            matrix3[i, j] = matrix3[i, j] + (matrix1[i, k] * matrix2[k, j]);
        }
    }
}
Console.WriteLine("Матрица 1");
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Произведение матриц");
PrintArray(matrix3);
*/



//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/*int x = InputInt("Введите размерность x: ");
int y = InputInt("Введите размерность y: ");
int z = InputInt("Введите размерность z: ");
int countNums = 89;

if (x * y * z > countNums)
{
   Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(x, y, z);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.Write($"{resultNums[i, j, k]} ({i},{j},{k})  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num
     = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }
    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/



/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}
PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
