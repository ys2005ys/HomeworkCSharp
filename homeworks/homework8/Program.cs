// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] Create2DArray(int colums, int rows)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(0,10); 

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

// int[,] Change2DArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//             int temp = array[i, k + 1];
//             array[i, k + 1] = array[i, k];
//             array[i, k] = temp;
//         }
//       }
//     }
//   }
//   return array;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] arr= Create2DArray(colums, rows);
// Show2DArray(arr);
// Console.WriteLine();
// Change2DArray(arr);
// Show2DArray(arr);




