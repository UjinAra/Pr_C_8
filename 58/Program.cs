// Задача 58: Задайте две матрицы. Напишите программу, которая 
//будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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
     int[,] rezArray(int[,] inArray,int[,] inArray2)

{
    int[,] rezMatrix= new int[inArray.GetLength(0),inArray2.GetLength(1)];

    for (int i = 0; i < inArray.GetLength (0); i++)
    {
        for (int j = 0; j < inArray2.GetLength (1); j++)
        {
            for (int m = 0; m < inArray.GetLength (1); m++)
             {
                rezMatrix [i,j] = inArray[i,m]*inArray2[m,j];
             }
        }
    }
    return rezMatrix;
}

int row = ReadFromConsole("Число строк массива");
int colm = ReadFromConsole("Число коллонок массива"); 
int minVal= ReadFromConsole("Начальное число диапазон"); 
int maxVal= ReadFromConsole("Конечное число диапазон"); 
int[,] array = GetArray(row,colm,minVal,maxVal);
 WriteLine ("1-ая матрица:");
PrintArray(array);
int[,] array2 = GetArray(row,colm,minVal,maxVal);
WriteLine ("2-ая матрица:");
PrintArray(array2);

int[,] rezMatrix = rezArray(array,array2);
WriteLine ("Результирующая матрица:");
PrintArray(rezMatrix);
