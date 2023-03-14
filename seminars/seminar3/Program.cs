// показать четные числа от 1 до N
// 1. Считать данные от пользователя
// 2. Cформировать строку из четных чисел



// string EvenNumbers(int N)
// {
//     string output = "";
//     int index = 2;
//     while (index <= N)
//     {
//        output = output + index + " ";
//         index = index + 2;
//     }
//     return output;
    
// }

// int GetNumber(string text)
// {
//     Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
        
// }   

// int N = GetNumber("введите число ");
// string result = EvenNumbers(N);
// Console.WriteLine(result);
// File.WriteAllText("file.txt", result);



// Задача 1.
// Реализовать перемешивание массива

// 1 Создание массива
int [] CreateArray(int size)
{ 
    return new int[size]; 
}

// 2 Ввод числа
int GetNumber(string text)
{
     Console.WriteLine(text);
     return Convert.ToInt32(Console.ReadLine());
        
}   

// 3 Печать массива
string PrintArray(int[] array)
{
    string result = String.Empty;
    int len = array.Length;
    int index = 0;
    while (index < len)
    {
        result = result + " " + array[index];
        index ++;

    }
    return result;
    
}

// 4 Заполнение массива
// 4.1  руками

void  FillByUser(int[] array)
{
    int size = array.Length;

    int index = 0;
    while (index < size)
    {
        array[index] = GetNumber("Введите " +index + " элемент : ");
        index++;
    }

}

int size = GetNumber("Введите размер массива");
int [] numbers = CreateArray(size);
Console.WriteLine(PrintArray(numbers));

FillByUser(numbers);
Console.WriteLine(PrintArray(numbers));

// 4.2 случайно


// 5 перемешивание массива
// int [] mus = GetMix(numbers);
// Console.WriteLine(PrintArray(numbers));

// 



