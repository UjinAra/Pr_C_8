// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
using static System.Console;
Clear(); 

int ReadFromConsole(string mess) // Метод ввода данных с консоли
{
    WriteLine (mess);
    return  Convert.ToInt32(ReadLine());
}
int [,] GetArray(int m, int n, int minVal, int maxVal)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //double r = Convert.ToDouble(x.Next(-100, 100)/10.0);
        result[i,j] =  new Random().Next(minVal,maxVal);
        }
    }
    return result;
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

int [,] ChangeArray(int[,] inArray)
{
    for (int i = 0; i < inArray .GetLength (0); i++)
    {
        for (int j = 0; j < inArray.GetLength (1); j++)
        {
            for (int m = 0; m < inArray.GetLength (1)-1; m++)
             {
                int res = inArray [i,m+1];
                if (inArray[i,m]<inArray[i,m+1])
                {
                    inArray[i,m+1]=inArray[i,m];
                    inArray[i,m]=res;
                }
             }
        }
    }
    return inArray;
}

int row = ReadFromConsole("Число строк массива");
int colm = ReadFromConsole("Число коллонок массива"); 
int minVal= ReadFromConsole("Начальное число диапазон"); 
int maxVal= ReadFromConsole("Конечное число диапазон"); 
int[,] array = GetArray(row,colm,minVal,maxVal);
PrintArray(array);
int[,] array2 = ChangeArray(array);
WriteLine ();
PrintArray(array2);
