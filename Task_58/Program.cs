// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.WriteLine("Введите число строк первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов первой матрицы, равное числу строк второй матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов второй матрицы: ");
int p = Convert.ToInt32(Console.ReadLine());


int[,] firstMartrix = new int[m, n];
Fill(firstMartrix);
Console.WriteLine($"Первая матрица:");
Print(firstMartrix);

int[,] secomdMartrix = new int[n, p];
Fill(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
Print(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Print(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


void Fill (int[,] nums)
{
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++)
    {
      nums[i, j] = new Random().Next(0,6);
    }
  }
}

void Print (int[,] nums)
{
  for (int i = 0; i < nums.GetLength(0); i++)
  {
    for (int j = 0; j < nums.GetLength(1); j++)
    {
      Console.Write(nums[i,j] + " ");
    }
    Console.WriteLine();
  }
}