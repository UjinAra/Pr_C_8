// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return  Convert.ToInt32(ReadLine());
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($" \t{inArray[i,j]} ");
        }    
        Console.WriteLine();
    }
} 


int n = ReadFromConsole("Число строк и столбцов массива");
int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < n - 1)
    j++;
  else if (i < j && i + j >= n - 1)
    i++;
  else if (i >= j && i + j > n - 1)
    j--;
  else
    i--;
}

PrintArray(matrix);

