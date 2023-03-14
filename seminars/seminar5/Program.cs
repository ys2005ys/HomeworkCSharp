// Создать массив из 12 элементов, заполненный случайными числами из промежутка (-9, 9)
// Найти сумму отрицательных и положительных чисел массива

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size]; // обязательное условие для создания массива
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // так как метод Next, то всегда добавлять +1
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");  // выводим массив в строку Write через пробел 
//     }
//     Console.WriteLine();  // делаем разрыв между строчками, чтобы они не слипались
// }
// void FinPosNegSum(int [] array)
// {
//     int sumpositiv = 0;
//     int sumnegativ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]>=0) sumpositiv += array[i];
//         else sumnegativ += array[i];

//     }
//     Console.WriteLine($"Sum of positive numbers in array -> {sumpositiv}, Sum of negative numbers in array -> {sumnegativ}");
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] MyArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(MyArray);
// FinPosNegSum(MyArray);




// Напишите программу замена элементов массива: положительные элементы замените на соответсвующие отрицательные, и наоборот.

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size]; // обязательное условие для создания массива
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // так как метод Next, то всегда добавлять +1
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");  // выводим массив в строку Write через пробел 
//     }
//     Console.WriteLine();  // делаем разрыв между строчками, чтобы они не слипались
// }

// int [] IvertArray(int[] array)
// {
    
//     for (int i = 0; i < array.Length; i++)
//     { 
//         array[i] = array[i] * (- 1); // array[i] *= (-1);
//     }
//     return array;
// }



// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] MyArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(MyArray);
// MyArray = IvertArray(MyArray);
// ShowArray(MyArray);

// Задайте массив. Напишите программу, которая определяет, присутствует ли число в массиве

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size]; // обязательное условие для создания массива
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // так как метод Next, то всегда добавлять +1
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");  // выводим массив в строку Write через пробел 
//     }
//     Console.WriteLine();  // делаем разрыв между строчками, чтобы они не слипались
// }

// bool FindNum(int[] array, int num)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num) return true;
        

//     }
//     return false;

// }


// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] MyArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(MyArray);
// Console.WriteLine(FindNum(MyArray, num));


// Задайте одномерный массив из 123 случайных чисел. Найдите количесвто элементов массива,
// значения которого лежат в отрезке [10,99]


// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size]; // обязательное условие для создания массива
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1); // так как метод Next, то всегда добавлять +1
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");  // выводим массив в строку Write через пробел 
//     }
//     Console.WriteLine();  // делаем разрыв между строчками, чтобы они не слипались
// }

// void NumsArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if ((array[i] >= 10) && ( array[i] <= 99 ))
//         {
//            count++; 
//         }
//     }
//      Console.WriteLine($"в массиве = {count}");
// }


// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] MyArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(MyArray);

// NumsArray(MyArray);