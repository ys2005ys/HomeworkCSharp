// Напишите программу, которая выводит случайные числа из отрезка [10, 99] и показывает наибольшую цифру числа

// void MaxDecimal (int num)
// {
//   int ed = num % 10;
//   int dec = num / 10;
//   if (ed > dec)
//   {
//     Console.WriteLine ($"большая цифра числа {num} -> {ed} "); // (если метод int, a не void), то return ed

//   }
//   else 
//   {
//     Console.WriteLine ($"большая цифра числа {num} -> {dec} "); // return dec

//   }
  

// }

// int rundomnumber =  new Random().Next(10, 99 + 1);

// MaxDecimal(rundomnumber);


///2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

// int DeleteDecimal (int num)

// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;

// }

// int rundomnumber =  new Random().Next(100, 1000);
// Console.WriteLine(rundomnumber)
// // int result = DeleteDecimal(rundomnumber);
// // Console.WriteLine(result);

// Console.WriteLine(DeleteDecimal(rundomnumber));


// 3. Напиште программу, которая на вход принимает число и проверяет кратно ли оно 7 и 23
 
// void NumberT (int num)
// {
//   if (num % 7 == 0 && num % 23 == 0)
//   {
//     Console.WriteLine("yes");
//   }
//  else
//   {
//     Console.WriteLine("not a number");


    
//   }

// }
// Console.WriteLine("input number");

// int num = Convert.ToInt32(Console.ReadLine());
// NumberT(num);


// 4. Написать программу, которая будет принимать на вход 2 числа и выводить, является ли число кратным первому. Если не кратно, то вывести остаток от деления.

// void TwoNumbersKrat(int num1, int num2)
// {
//     if (num1 / num2 == 0)
//     {
//         Console.WriteLine("kratno");
//     }
//     else
//     {
//         Console.WriteLine($"остаток от деления равен {num1}/{num2}= {num1 % num2}");
    
//   }
// }
// Console.WriteLine("input 1 number");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input 2 number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// TwoNumbersKrat(num1, num2);







