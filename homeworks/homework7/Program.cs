// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// double[,] Create2DRandomArray(int colums, int rows)
// {  
//     double[,] newArray = new double[rows, colums];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//            newArray[i, j] = random.Next(-10, 10)+  random.NextDouble();
//         }
//     }
//     return newArray;
// }

// void Show2DArrayrray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             Console.Write(Math.Round(array[i,j] , 1) + " "); 
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); 
// }

// Console.WriteLine("Input number m: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number n: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// double[,] array = Create2DRandomArray(colums, rows);
// Show2DArrayrray(array);




// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray(int colums, int rows)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(0,100); 

//         }
//     }
//     return newArray;

// }

// void Show2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             Console.Write(array[i, j] + " ");  
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); 
// }
 
// void IndexNumer(int[,] array, int n, int m)
// {
//     if (n > array.GetLength(0) || m > array.GetLength(1))
//     {
//         Console.WriteLine("такого элемента нет");
//     }
//     else
//     {
//         Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {array[n-1,m-1]}"); 
//         //!!!!! если мы считаем, что нумерация не идет с 0-й позиции
//     }
// }

 
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());


// int[,] array = Create2DRandomArray(colums, rows);
// Show2DArray(array);
// IndexNumer(array, n, m);



// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int colums, int rows)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(0,100); 

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

void Avarege(int[,] array, int rows)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i <array.GetLength(0); i++)
        {
            result = (result + array[i, j]);
        }
        result = result / rows;
        Console.Write(result + "; ");
    }
    Console.WriteLine();
}



Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());


int[,] array = Create2DRandomArray(colums, rows);
Show2DArray(array);
Avarege(array, rows);














// void ArrayNumbers(int[,] array)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(); 

//         }
//     }
   
// }
// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) 
//     {
//         for (int j = 0; j < array.GetLength(1); j++) 
//         {
//             Console.Write(array[i, j] + " ");  
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); 
// }

// int ReturnIndex(int[,] array)
// {
//     int[,] numbers = new int[rows, colums];
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         int result = 0;
//         for (int i = 0; i < numbers.GetLength(0); i++)
//         {
//             result = (result + numbers[i, j]);
//         }
//         result = result / rows;
//         Console.Write(result + "; ");
//     }
//     Console.WriteLine();
// }
