﻿// Console.WriteLine("2 Hello, World ");

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.WriteLine("Введите число");

// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
    
//     if (y==x)
//  {
//     Console.WriteLine ("Числа равны");}
   
//     if (x > y) 
  
//     {
//     Console.WriteLine (x);}  
//     else
//     {
//            Console.WriteLine (y);
//     }

   

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("(Введите число)");

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
 
//  if (a==b && b==c)
//   {
//      Console.WriteLine ("Числа равны");}
// if (a>b && a>c) 
//   {
//   Console.WriteLine (a);}  
//     else
//     {
//            Console.WriteLine (c);
//                 }
   

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

//  Console.WriteLine("(Введите число)");

//  int x = Convert.ToInt32(Console.ReadLine());
//   if (x % 2==0)
//  {
//      Console.WriteLine ("да");}
//      else 
// {Console.WriteLine ("нет");}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("(Введите число)");

// int N = Convert.ToInt32(Console.ReadLine());

//  for (int I=2; I<=N; I=I+2)

//   {
//     Console.WriteLine (I);}

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

//  Console.WriteLine("(Введите число)");
//  int num1 = Convert.ToInt32(Console.ReadLine()); 
//  Console.WriteLine (num1/10%10);

// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// // 645-> 5

// // 78 -> третьей цифры нет

// // 32679 -> 6

//  Console.WriteLine("(Введите число)");
//  int num1 = Convert.ToInt32(Console.ReadLine());
//  if (num1/100==0) 
//  {
//     Console.WriteLine("третьего числа нет");
//     }
//  else 
//  {
//     while (num1>999) 
//     {num1/=10;}
// Console.WriteLine (num1%10);
// }


// // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// // 6 -> да
// // 7 -> да
// // 1 -> нет

// Console.WriteLine("Какой сегодня день?");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1==7|| num1==6)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// } 
