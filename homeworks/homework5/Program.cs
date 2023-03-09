// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray(int size) 
// {
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000); 
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");  
//     }
//     Console.WriteLine();  
// }
// void NumsEvenArray(int[] array)
// {
//     int index = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//            index++; 
          
//         }
//     }
//      Console.WriteLine($"в массиве четных чисел {index}");
// }


// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] MyArray = CreateRandomArray(size);
// ShowArray(MyArray);
// NumsEvenArray(MyArray);





// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size]; 
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); 
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");  
//     }
//     Console.WriteLine();  
// }

// void FindOddSum(int [] array)
// {
//     int index = 0;
//     int sum = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//        if ( i % 2 == 1)
//        {
//          sum += array[i];
//          index++;
//        }

//     }
   
//     Console.WriteLine($"Сумма нечетных элементов -> {sum}");
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] MyArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(MyArray);
// FindOddSum(MyArray);




// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


 double[] RandomArray(int size)
 {
    
    double[] array = new double[size]; 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();

    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");  
    }
    Console.WriteLine();  
}

double Dif(double[] array)
{
    double min = array[0];
    double max = array[0];
    int i = 1;
    while (i < array.Length)
    {
       if (max < array[i])
       max = array[i];
       if (min > array[i])
       min = array[i];
       i = i + 1;
    }
    return max-min;
   
    
}


Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] MyArray = RandomArray(size);
ShowArray(MyArray);
Dif(MyArray);
Console.Write($"Разница между максимальным и минимальным элементов массива: {Dif(MyArray)}");





