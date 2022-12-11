// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой 
// элементов. Например, задан массив:
// 1 4 7 2
// 5 9 2 3 
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
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

int SummArray(int[,] inArray)
{
  int summA = 0;
  int minSumm = 0;
  int index = 0;
    for (int i = 0; i < inArray.GetLength (0); i++)
    {
        summA =0;
        for (int j = 0; j < inArray.GetLength (1); j++)
        {
         summA  = summA  + inArray[i,j];
        }
        if (i==0)
        {
            minSumm = summA;
        }
        if (minSumm > summA )
        {
            summA = minSumm;
            index=i+1;
        }
    }
    return index;
}

int row = ReadFromConsole("Число строк массива");
int colm = ReadFromConsole("Число коллонок массива"); 
int minVal= ReadFromConsole("Начальное число диапазон"); 
int maxVal= ReadFromConsole("Конечное число диапазон"); 
int[,] array = GetArray(row,colm,minVal,maxVal);
PrintArray(array);
int summA = SummArray(array);
WriteLine ();
WriteLine($"{summA} строка");
