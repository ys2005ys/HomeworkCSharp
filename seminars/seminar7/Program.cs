// Задайте двумерный массив m*n, заполненный случайными числами

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
// //Show2DArrayrray(Create2DRandomArray(colums, rows, minValue, maxValue));





// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле А= m+n
// выведите полученный массив на экран

// int[,] Create2DArray(int colums, int rows)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = i+j; 

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

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// Show2DArrayrray(Create2DArray(colums, rows));




// Задайте двумерный массив. Найдите эелементы, у которых оба индекса четные и замените эти индексы на их квадраты

// int[,] Create2DArray(int colums, int rows)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = i+j; 

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

// int[,] Findeven(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++) //��
//     {
//         for (int j = 0; j < array.GetLength(1); j++) //��
//         if (i % 2 == 0 && j % 2 == 0) 
//         {
//             array[i,j] = array[i,j] * array[i,j];
//         }
//     }
//     return array;
    

// }



// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray= Create2DArray(colums, rows);
// Show2DArrayrray(Create2DArray(colums, rows));
// Console.WriteLine();

// Findeven(MyArray);
// Console.WriteLine();
// Show2DArrayrray(Findeven(MyArray));



//Задайте двумерный массив. Найдите сумму элементов, находящихся на гоавной диагонали (с индексами (0,0); (1,1); и тд)

int[,] Create2DArray(int colums, int rows)
{
    int[,] newArray = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = i+j; 
            

        }
    }
    return newArray;

}

void Show2DArrayrray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) //пробегаемся по строке
    {
        for (int j = 0; j < array.GetLength(1); j++) // пробегаемся по столбцу, поэтому 1
        {
            Console.Write(array[i, j] + " ");  //добавляем пробел, чтобы не слипались
        }
        Console.WriteLine();
    }
    Console.WriteLine(); // добавляем пробел, чтобы не слипались массивы
}

int FindMainDiagonal(int[,] array)
{

    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) 
    {       
        for (int j = 0; j < array.GetLength(1); j++) 
        if (i == j) 
        {
            sum += array[i, j];
        }
    }
    return sum;
    
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());


int[,] MyArray= Create2DArray(colums, rows);
Show2DArrayrray(MyArray);

//FindMainDiagonal(MyArray); так нельзя, так как метод интовый
Console.WriteLine($"Main diagonal: {FindMainDiagonal(MyArray)}");

