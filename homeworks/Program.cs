// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии


// void ShowNambers (int n)
// {
//     if (n >= 1)
//     {
//        Console.Write(n + " ");
//        ShowNambers(n - 1);

//     }
    
// }


// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// ShowNambers(n);



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
 
// int FS(int m, int n)
// {
//    if (n!=m)
//    {
   
//         if (n >  m)
//         {
        
//           return FS(m + 1 , n - 1 ) + m + n;
            
//         }
//         else return 0;

    
//     }
//     else return n;

// }

// Console.WriteLine(FS(1,15));

/*
int Akkerman(int n, int m)
{
    if (m == 0)
    {
        return n + 1;
    }
    
    else if ((m > 0) && (n == 0))
        { 
            return Akkerman(m - 1, 1);
        }
            
         else 
        {           
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
            
        
}

Console.WriteLine(Akkerman(0,2));
*/




        





