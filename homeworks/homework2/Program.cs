// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


// int SecondDigital (int num)

// {
//     int dig = num / 10 % 10 ;
    
//     Console.WriteLine($"вторая цифра num = {num}");

//     return dig;
// }


// int rundomnumber =  new Random().Next(100, 1000);
// int num = Convert.ToInt32(rundomnumber);
// if 
//     (num < 100 && num >= 1000)
//     {
//         Console.WriteLine($"Vvedie korrektnoe czislo");
//         return;

//     }

// Console.WriteLine(SecondDigital(num));




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.Write("Введи число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2)
// {
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else
//  {
//   Console.WriteLine("-> третьей цифры нет");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введи цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int dayNumber)
// {
//   if (dayNumber == 6 || dayNumber == 7) 
//   {
//   Console.WriteLine("(этот день выходной) -> да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7)
//  {
//     Console.WriteLine("введите корректное число от 1 до 7");
//  }
//   else Console.WriteLine("(этот день не выходной) -> нет");
// }

// CheckingTheDayOfTheWeek(dayNumber);














