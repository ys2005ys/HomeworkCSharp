// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int NumPower(int num, int pow)
// {
//    int power= 1;
//    for (int i=0; i<pow; i++)
//    {
//     power = power*num;
//    }
//    return power;
   
// }

// Console.WriteLine("Input A number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input B number: ");
// int pow = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(NumPower(num, pow));




//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// int FindSum(int a)
// {
//    int sum = 0;
//    while (a > 0)
//    {
//        sum += a % 10;
//        a = a / 10;
//    }
//    return sum;
// }
// Console.WriteLine("Input A number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(FindSum(a));




//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateRandomArray(int size) 
{
    int[] array = new int[size]; // обязательное условие для создания массива
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");  // выводим массив в строку Write через пробел 
    }
    Console.WriteLine();  // делаем разрыв между строчками, чтобы они не слипались
}

Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandomArray(size);
ShowArray(MyArray);


