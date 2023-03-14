// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива
// есть массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// итог:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

//РЕАЛИЗУЕМ МЕТОД ПОИНТЕРЕСНЕЕ, ОН УБДЕТ МЕНЯТЬ ЛЮБУЮ С ЛЮБОЙ СТРОКИ


// int[,] Create2DRandomArray(int colums, int rows, int minvalue, int maxvalue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minvalue, maxvalue+1); // обязательно

//         }
//     }
//     return newArray;

// }

// void Show2DArrayrray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) //пробегаемся по строке
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // пробегаемся по столбцу, поэтому 1
//         {
//             Console.Write(array[i, j] + " ");  //добавляем пробел, чтобы не слипались
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); // добавляем пробел, чтобы не слипались массивы
// }

// int[,] ChR(int[,] array, int row1, int row2) // меняем строчки, которые захотим
// {
//     row1 = row1 - 1;
//     row2 = row2 - 1;
//     if ((row1 > array.GetLength(0)) || (row2 > array.GetLength(0)) || (row1 < 0) || (row2 < 0))
//     {
//         Console.WriteLine("Invalid rows");
//         return array;
//     }
    
//     else
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // перебираем цифры по столбцам
//         {
//             int temp = array[row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArrayrray(myArray);
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of first row to change: ");
// int row2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of second row to change: ");
// myArray = ChR(myArray, row1, row2);
// Show2DArrayrray(myArray);




// задайте двуметный массив. Напишите программу, которая заменяет строки на столбцы.
//в случае, если это невозможно, программа должна вывести сообщение для пользователя


// int[,] Create2DRandomArray(int colums, int rows, int minvalue, int maxvalue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minvalue, maxvalue+1); // обязательно

//         }
//     }
//     return newArray;

// }

// void Show2DArrayrray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) //пробегаемся по строке
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // пробегаемся по столбцу, поэтому 1
//         {
//             Console.Write(array[i, j] + " ");  //добавляем пробел, чтобы не слипались
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); // добавляем пробел, чтобы не слипались массивы
// }

// int[,] RowsToColumns(int[,] array)
// { 
//     if (array.GetLength(0)!= array.GetLength(1))
//     {
//         Console.WriteLine("Rows and columns count mismatch");
//         return array;
//     }
//     else
//     { 
//         for (int i = 0; i < array.GetLength(0) - 1; i++) // чтобы не проходить последний элемент в последней строке
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             { 
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;

//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArrayrray(array);
// Show2DArrayrray(RowsToColumns(array));




//из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент
// не удаляем, за все элементы заменим нулями


// int[,] Create2DRandomArray(int colums, int rows, int minvalue, int maxvalue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minvalue, maxvalue+1); // обязательно

//         }
//     }
//     return newArray;

// }

// void Show2DArrayrray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) //пробегаемся по строке
//     {
//         for (int j = 0; j < array.GetLength(1); j++) // пробегаемся по столбцу, поэтому 1
//         {
//             Console.Write(array[i, j] + " ");  //добавляем пробел, чтобы не слипались
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine(); // добавляем пробел, чтобы не слипались массивы
// }

// int[,] DeliteMinElement(int[,] array)
// {
//     int min = array[0, 0];
//     int rowMin = 0;
//     int columMin = 0;
//     // ищем минимум и индекс его строки и столбца
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 rowMin = i;
//                 columMin = j;
//             }
//         }
//     }
//     // обнуление столбца
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i, columMin] = 0;
//     }
//     // обнуление строки
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[rowMin, j] = 0;

//     }
//     return array;
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] array = Create2DRandomArray(colums, rows, minValue, maxValue);
// Show2DArrayrray(array);
// Show2DArrayrray(DeliteMinElement(array));



//newArray[i, j] = new Random().Next() + new Random().NextDouble();// обязательно