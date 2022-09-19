// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите колличество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = FillArray(m, n);
PrintArray(array);
Console.WriteLine();
var summList = SummList(array);
Console.WriteLine();
PrintMinimumString(summList);


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
List<int> SummList(int[,] array)
{
	var summList = new List<int>();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		int summ = 0;
		for (int j = 0; j < array.GetLength(1); j++)
		{
			summ += array[i, j];
		}
		summList.Add(summ);
		Console.WriteLine(summList[i]);
	}
	return summList;
}
void PrintMinimumString(List<int> minString)
{
	for (int i = 0; i < minString.Count; i++)
	{
		if (minString[i] == minString.Min())
			Console.WriteLine("Строчка с наименьшей суммой = " + (i + 1));
	}
}
