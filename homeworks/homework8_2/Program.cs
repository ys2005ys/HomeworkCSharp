// //Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Create2DArray(int colums, int rows)
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

// void MinSumRow (int [,] array)
// {
//     int sum = 0;
//     int index = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int temp = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     temp += array[i, j];
//                 }
//                 if (temp > sum)
//                 {
//                     sum = temp;
//                     index = i;
//                 }
//             }
//             Console.WriteLine("строка: ");
//             for (int i = 0; i < array.GetLength(1); i++)
//             {
//                 Console.Write(array[i, index]);
//             }
// }
 
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] arr= Create2DArray(colums, rows);
// Show2DArray(arr);
// Console.WriteLine();
// MinSumRow(arr);


