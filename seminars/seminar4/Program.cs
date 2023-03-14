// напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
// 7 - 28
// 4 - 10
// 8 - 36

//int FindSum(int a)
//{
//    int sum = 0;
//    for (int count = 1; count <= a; count++)
//    {
//        sum += count;   // sum = sum + count
//    
//    }
//    return sum;
//}
//Console.WriteLine("Input A number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(FindSum(a));




// Напишите программу, которая вводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// зададим массив произвольного размера, запросим у пользователя

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

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);

// ShowArray(myArray);

// Напишите программу, котороая принимает на ввод число и выдает кол-во цифр в числе

// int CountNumber(int number)
// {
//     int count = 0;
//     while (count < number)
//     {
//         number = number / 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(CountNumber(number));




// Напишите программу, котороя принимает на вход число N и выдает произведение чисел от 1 до N


int Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine("Input number N: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Factorial(a));
