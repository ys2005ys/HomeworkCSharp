// Напишите прошграмму, которая перевернет одномерный массив (последний элемент будет на первом месте
//а первый - на последнем)

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

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = temp; // для того, чтобы двигаться как слева, так и справа
//     }

//     return array;
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input mimValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[]MyArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(MyArray);
// int[]reversearray = ReverseArray(MyArray);
// ShowArray(reversearray);



// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
//со сторонами такой длины. самое важное знать правило: каждая сторона должна быть меньше (строго) суммы двух 
//других сторон

// так как в задаче может либо не может, применяем метод bool

// bool ChekTriangle(int x, int y, int z)
// {
//     if ((x < y + z) && (y < x + z) && (z < x + y))
//     {
//         return true;
//     }
//     return false;
// }

// Console.WriteLine("Введите сторону А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону В: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите сторону С: ");
// int c = Convert.ToInt32(Console.ReadLine());

// //bool result = ChekTriangle(a, b, c);  можно еще так вызвать метод
// //Console.WriteLine(result);

// Console.WriteLine($"Треугольник со сторонами A: {a}, B: {b}, C: {c} может существовать? {ChekTriangle(a, b, c)}");



// Не использую рекрусию, введите первые N чесел Фибаначчи. Первые два числа Фибаначии: a и b 
// числа Фибанначи - последовательность чисе, в которой первые 2 числа - это 0 и 1, а последующие - сумма двух предыдущих


int[] Fibonacci(int a, int b, int size)
{
    int[] myArray = new int[size];
    myArray[0] = a;
    myArray[1] = b;
   
    for (int i = 2; i < myArray.Length; i++)
    {
       myArray[i] = myArray[i - 1] + myArray[i - 2];
    }
    return myArray;
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
Console.WriteLine("Input A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B: ");
int b = Convert.ToInt32(Console.ReadLine());

int[]MyArray = Fibonacci(a, b, size);
ShowArray(MyArray);




// напишите программу, которая будет преобразовывать десятичное число в двоичное
// 45- 101101
// 3 - 11
// 2 - 10

// void DoubleNumber(int num)
// {
//     string sum = String.Empty;
//     while (num > 0)
//     {
//        sum =  num % 2 + sum; // именно в такой последовательности будет отзеркаливать
//        num = num / 2;
//     }
//     Console.WriteLine(sum);
   
// }

// Console.WriteLine("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// DoubleNumber(num);
