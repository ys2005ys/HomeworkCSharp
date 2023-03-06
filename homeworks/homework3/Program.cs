﻿//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//Console.Write("Введите пятизначное число: ");
//string? number = Console.ReadLine();

//void IsPalindrom(string number)
//{
//  if (number[0]==number[4] || number[1]==number[3])
//  {
//   Console.WriteLine($"Ваше число: {number} - да, палиндром.");
//  }
//  else Console.WriteLine($"Ваше число: {number} - нет, не палиндром.");
//}

//if (number!.Length == 5)
//{
// IsPalindrom(number);
//}
//else Console.WriteLine($"Вы ввели не пятизначное число, повторите");



//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53


//int x1 = Coordinat("x", "A");
//int y1 = Coordinat("y", "A");
//int z1 = Coordinat("z", "A");
//int x2 = Coordinat("x", "B");
//int y2 = Coordinat("y", "B");
//int z2 = Coordinat("z", "B");

//int Coordinat(string coordinatName, string point)
//{
//    Console.Write($"Введите координату {coordinatName} точки {point}: ");
//   return Convert.ToInt32(Console.ReadLine());
//}

//double Total(double x1, double x2, 
//             double y1, double y2, 
//             double z1, double z2)
//{
//  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                   Math.Pow((y2-y1), 2) + 
//                   Math.Pow((z2-z1), 2));
//}

//double segmentLength =  Math.Round (Total(x1, x2, y1, y2, z1, z2), 2 );

//Console.WriteLine($"Длина отрезка  {segmentLength}");



//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
