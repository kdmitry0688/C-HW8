// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array1 = FillArray(2, 2);
int[,] array2 = FillArray(2, 2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
int[,] resultArray = new int[2, 2];
Console.WriteLine();
PrintArray(Matrix(array1, array2, resultArray));


int[,] FillArray(int m, int n)
{
	int[,] array = new int[m, n];
	for (int i = 0; i < m; i++)
	{
		for (int j = 0; j < n; j++)
		{
			array[i, j] = new Random().Next(0, 10);
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
			Console.Write(array[i, j] + " ");
		}
		Console.WriteLine();
	}
}

int[,] Matrix(int[,] array1, int[,] array2, int[,] resulArray)
{
	for (int i = 0; i < resultArray.GetLength(0); i++)
	{
		for (int j = 0; j < resultArray.GetLength(1); j++)
		{
			int sum = 0;
			for (int k = 0; k < array1.GetLength(1); k++)
			{
				sum += array1[i, k] * array2[k, j];
			}
			resultArray[i, j] = sum;
		}
	}
	return resulArray;
}