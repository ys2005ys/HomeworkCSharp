// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*int[,] Create2DArray(int colums, int rows)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(0,10); 

        }
    }
    return newArray;

}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

int[,] Change2DArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
            int temp = array[i, k + 1];
            array[i, k + 1] = array[i, k];
            array[i, k] = temp;
        }
      }
    }
  }
  return array;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arr= Create2DArray(colums, rows);
Show2DArray(arr);
Console.WriteLine();
Change2DArray(arr);
Show2DArray(arr);
*/




//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*int[,] Create2DArray(int colums, int rows)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(0,10); 

        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

int SumRowElements(int[,] array, int i)
{
    int sumRow = array[i,0];
    
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumRow += array[i,j];
       
    }
    return sumRow;
    
}

void FindMinSum(int[,] array)
{
    int minSumRow = 0;
    int sumRow = SumRowElements(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int result = SumRowElements(array, i);
        if (sumRow > result)
        {
            sumRow = result;
            minSumRow = i;
        }
    }
    Console.WriteLine($"строкa номер {minSumRow+1} с наименьшей суммой элементов, сумма равна ({sumRow})");
    
}


Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arr= Create2DArray(colums, rows);
Show2DArray(arr);
FindMinSum(arr);
*/



/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*int[,] CreatetMatrix(int[,] array)
{   
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++) 
        {
            array[i, j] = new Random().Next(0,10); 
        }
    }
    return array;

}

void Show2DArrayrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

 int[,] ProductMatrix(int[,] firstMatrix, int[,] secomdMartrix, int[,] resultMatrix)
{
   
  for (int i = 0; i < firstMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < secomdMartrix.GetLength(1); j++)
    {
      
      for (int k = 0; k < secomdMartrix.GetLength(0); k++)
      
      {
        resultMatrix[i,j] += firstMatrix[i,k] * secomdMartrix[k,j];
      }
      
    }
  }
  return resultMatrix;
}


Console.WriteLine("Input number of rows matrix1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums matrix1 (= number of rows matrix2): ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums matrix2: ");
int p = Convert.ToInt32(Console.ReadLine());



int[,] firstMatrix = new int[m, n];
CreatetMatrix(firstMatrix);
Console.WriteLine($"Первая матрица:");
Show2DArrayrray(firstMatrix);
Console.WriteLine();

int[,] secomdMartrix = new int[n, p];
CreatetMatrix(secomdMartrix);
Console.WriteLine($"Вторая матрица:");
Show2DArrayrray(secomdMartrix);
Console.WriteLine();

int[,] resultMatrix = new int[m,p];
ProductMatrix(firstMatrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Show2DArrayrray(resultMatrix);
*/






