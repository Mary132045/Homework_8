// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m, n];

int[,] nums = new int[m, n];
Fill(nums);
Print(nums);

Console.WriteLine($"Отсортированный массив: ");
Decrease(nums);
Print(nums);

void Decrease(int[,] nums)
{
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++)
    {
      for (int k = 0; k < nums.GetLength(1) - 1; k++)
      {
        if (nums[i, k] < nums[i, k + 1])
        {
          int temp = nums[i, k + 1];
          nums[i, k + 1] = nums[i, k];
          nums[i, k] = temp;
        }
      }
    }
  }
}

void Fill(int[,] nums)
{
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++)
    {
      nums[i, j] = new Random().Next(0, 10);
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