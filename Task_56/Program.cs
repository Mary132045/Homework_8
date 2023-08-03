// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите колиство строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[m, n];

    int SumLineElements(int[,] array, int i)
    {
        int sumLine = nums[i, 0];
        for (int j = 1; j < nums.GetLength(1); j++)
        {
            sumLine += nums[i, j];
        }
        return sumLine;
    }


void Fill(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            nums[i, j] = new Random().Next(0, 6);
        }
    }
}

void Print(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void MinString(int[,] nums)
{
    int minSumLine = 0;
    int sumLine = SumLineElements(nums, 0);
    for (int i = 1; i < nums.GetLength(0); i++)
    {
        int tempSumLine = SumLineElements(nums, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
    }
    int k = minSumLine;
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        Console.Write($"{nums[minSumLine, j]} ");

    }
    {
        Console.WriteLine();
    }
    Console.WriteLine($"Строка {minSumLine + 1} с наименьшей суммой элементов равной {sumLine}.");
}
{
    Console.WriteLine();
}
Fill(nums);
Print(nums);
Console.WriteLine();
MinString(nums);




