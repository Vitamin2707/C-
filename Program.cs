// Console.WriteLine("2 Hello, World ");

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

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите число");
// string num1 = Console.ReadLine();
// string num2 = string.Empty;
// for (int I = num1.Length-1; I>=0; I--)
// {
//     num2 += num1 [I];
// }
// if (num1==num2)
// {
//     Console.WriteLine ("Число является палиндромом");
// }
// else 
// {
//     Console.WriteLine ("Число не является палиндромом");
// }


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите x1");
// int x1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1");
// int y1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1");
// int z1=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2");
// int x2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2");
// int y2=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2");
// int z2=Convert.ToInt32(Console.ReadLine());
// double lenght = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// Console.WriteLine (Math.Round (lenght,2));

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите N");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int I = 1; I<=N; I++)
// {
// Console.WriteLine(I+ " => " + Math.Pow (I , 3));
// }

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
  
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine(+ exponentiation);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberN){
    
//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = numberN - numberN % 10;
//       result = result + (numberN - advance);
//       numberN = numberN / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


// Console.Write("Введите ряд чисел, разделенных запятой : ");
// string? seriesOfNumbers = Console.ReadLine();

// seriesOfNumbers = seriesOfNumbers + ",";    

// string RemovingSpaces (string series){
//   string seriesNew = "";
//   for (int i = 0; i < series.Length; i++)
//   {
//     if (series[i] != ' ') 
//     {
//       seriesNew += series[i];
//     }
//   }
//   return seriesNew;
// }
// void СheckNumber2 (int  series){

//       if (series == '0'||series == '1'||series == '2'
//       ||series == '3'||series == '4'||series == '5'||series == '6'
//       ||series == '7'||series == '8'||series == '9'||series == ','
//       ||series == '-')
//       {
//       }
//         else {
//           Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

//       }
// }
// int[] ArrayOfNumbers(string seriesNew){ 

//   int[] arrayOfNumbers = new int[1];   

//   int j =0;

//   for (int i = 0; i < seriesNew.Length; i++){
//     string seriesNew1 = "";

//     while (seriesNew[i] != ',' && i < seriesNew.Length){
//       seriesNew1 += seriesNew[i];
//       СheckNumber2(seriesNew[i]);
//       i++;
//     }
//     arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
//     if (i < seriesNew.Length-1){
//       arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    
//     }
//     j++;
//   }
//   return arrayOfNumbers;
// }
// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   Console.Write("[");
//   while(index < count){
//     Console.Write(coll[index]);
//     index++;
//     if (index < count){
//       Console.Write(", ");
//     }
//   }
//   Console.Write("]");
// } 


// string seriesNew = RemovingSpaces(seriesOfNumbers);

// int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

// PrintArry(arrayOfNumbers);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Масив: ");
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = new Random().Next(1,10);
//         }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Clear();

// Console.Write($"Введи количество чисел M : ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[] massiveNumbers = new int[m];

// void InputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//  Console.Write($"Введи {i+1} число: ");
//  massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
//   }
// }


// int Comparison(int[] massiveNumbers)
// {
//  int count = 0;
//  for (int i = 0; i < massiveNumbers.Length; i++)
//   {
//  if(massiveNumbers[i] > 0 ) count += 1; 
//   }
//  return count;
// }

// InputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");

// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

// double[,] coeff = new double[2, 2];
// double[] crossPoint = new double[2];

// void InputCoefficients(){
//   for (int i = 0; i < coeff.GetLength(0); i++)
//   {
//     Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
//     for (int j = 0; j < coeff.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите коэффициент k: ");
//       else Console.Write($"Введите коэффициент b: ");
//       coeff[i,j] = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }

// double[] Decision(double[,] coeff)
// {
//   crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
//   crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
//   return crossPoint;
// }

// void OutputResponse(double[,] coeff)
// {
//   if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые совпадают");
//   }
//   else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые параллельны");
//   }
//   else 
//   {
//     Decision(coeff);
//     Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
//   }
// }

// InputCoefficients();
// OutputResponse(coeff);

// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// Console.WriteLine($"m = {m}, n = {n}.");

// double[,] array = new double[m, n];

// CreateArrayDouble(array);

// WriteArray(array);

// Console.WriteLine();

// void CreateArrayDouble(double[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().NextDouble() * 20 - 10;
//     }
//   }
// }

// void WriteArray (double[,] array){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         double alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }

// // Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

// Console.WriteLine($"Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

// Console.Write("\nMассив возьмем из предыдущей задачи (№ 47).\n");
// Console.Write("Введите координаты позиции элемента, разделенных запятой: ");

// string? positionElement = Console.ReadLine();
// positionElement = RemovingSpaces(positionElement);
// int[] position = ParserString(positionElement);

// if(position[0] <= m 
// && position[1] <= n 
// && position[0] >= 0 
// && position[1] >= 0) 
// {
//   double result = array[position[0]-1, position[1]-1];
//   Console.Write($"Значение элемента: {result}");
// }
// else Console.Write($"такого элемента в массиве нет.");

// int[] ParserString(string input)
// {
//   int countNumbers = 1;
//   for (int i = 0; i < input.Length; i++)
//   {
//       if (input[i] == ',')
//           countNumbers++;
//   }

//   int[] numbers = new int[countNumbers];

//   int numberIndex = 0;
//   for(int i = 0; i < input.Length; i++)
//   {
//     string subString = String.Empty;

//     while (input[i] != ',')
//     {
//       subString += input[i].ToString();
//       if (i >= input.Length - 1)
//         break;
//       i++;
//     }
//     numbers[numberIndex] = Convert.ToInt32(subString);
//     numberIndex++;
//   }

//   return numbers;
// }

// string RemovingSpaces (string input)
// {
//   string output = String.Empty;
//   for (int i = 0; i < input.Length; i++)
//   {
//     if (input[i] != ' ') 
//     {
//       output += input[i];
//     }
//   }
//   return output;
// }

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

// Console.WriteLine($"\n\nЗадача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
// Console.Write("\nMассив возьмем из предыдущей задачи (№ 47), преобразовав double в int32.\n");

// int[,] arrayWhole = new int[m, n];
// arrayWhole = TransformationArrayWhole(array);

// WriteArrayInt(arrayWhole);

// Console.Write($"\nCреднее арифметическое:\n");
// for (int i = 0; i < n; i++)
// {
//   double arithmeticMean = 0;
//   for (int j = 0; j < m; j++)
//   {
//     arithmeticMean += arrayWhole[j, i];
//   }
//   arithmeticMean = Math.Round(arithmeticMean / m, 1);
//   Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
// }

// int[,] TransformationArrayWhole (double[,] array)
// {
//   int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
//     }
//   }
//   return arrayWhole;
// }

// void WriteArrayInt (int[,] arrayWhole){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         Console.Write(arrayWhole[i, j] + " ");
//       }
//       Console.WriteLine();
//   }
// }


// Задача 57: Составить частотный словарь элементов двумерного массива. 
// // Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int m = 6;
// int n = 6;
// int[,] array = new int[m, n];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int count = 0;
// int[,] dictionary = new int[m * n, 2];
// int k = 0;

// bool exist = false;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         exist = false;
//         for (int r = 0; r < k; r++)
//         {
//             if (dictionary[r, 0] == array[i, j])
//             {
//                 dictionary[r, 1]++;
//                 exist = true;
//                 break;
//             }
//         }
//         if (exist == false)
//         {
//             dictionary[k, 0] = array[i, j];
//             dictionary[k, 1]++;
//             k++;
//         }
//     }
// }
// for (int i = 0; i < k; i++)
// {
//     for (int j = 0; j < dictionary.GetLength(1); j++)
//     {
//         Console.Write($"{dictionary[i, +j]} ");
//     }
//     Console.WriteLine();
// }

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8


// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// Console.WriteLine($"\nОтсортированный массив: ");
// OrderArrayLines(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, заданы 2 массива:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// и

// 1 5 8 5

// 4 9 4 2

// 7 2 2 6

// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10

// 20 81 8 6

// 56 8 4 24

// 10 6 24 49


// Console.WriteLine($"\nВведите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"\nПервая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"\nВторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"\nПроизведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)

// 45(1,0,0) 53(1,0,1)

// Console.WriteLine($"\nВведите размер массива X x Y x Z:");
// int x = InputNumbers("Введите X: ");
// int y = InputNumbers("Введите Y: ");
// int z = InputNumbers("Введите Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }

// Задача 62. Заполните спирально массив 4 на 4. Не сделал ...

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

// Console.Clear();
// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }
// --
//  // Console.Write("Введите натуральное число: ");
// // int N = Convert.ToInt32(Console.ReadLine());
// // for (int i = 1; i <= N; i++)
// // {
// //     Console.Write($"{i} ");
// // }
// // Console.WriteLine();
// void PrintNumbersStringType(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {

//         Console.Write($"{i} ");
//     }
//     Console.WriteLine();
// }
// string PrintNumbersStringType(int number)
// {
//     string result = "";
//     for (int i = 1; i <= number; i++)
//     {
//         result += i.ToString()+" ";
//     }
//    return result;
// }



// Console.Clear();
// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(N);
// Console.WriteLine(PrintNumbersStringType(N)); 

// void PrintNumbers(int number)
// {
//     for (int i = 1; i <= number; i++)
//     {

//         Console.Write($"{i} ");
//     }
//     Console.WriteLine();
// }
// string PrintNumbersStringType(int number)
// {
//     string result = "";
//     for (int i = 1; i <= number; i++)
//     {
//         result =  result + " " + i.ToString();
//     }
//    return result;
// }
//Рекурсия
// string PrintNumbersRecusiveType(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbersRecusiveType(start+1, end));
// }
// Console.Clear();
// Console.Write("Введите натуральное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecusiveType(1, N)) ;


// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N

// string PrintNumbersRecusiveType(int start, int end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumbersRecusiveType(start+1, end));
// }
// Console.Clear();
// //PrintNumbers(N);
// //Console.WriteLine(PrintNumbersStringType(N)) ;
// Console.Write("Введите натуральное число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(PrintNumbersRecusiveType(M, N));

// Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12

// 45 -> 9

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{N}-> { SumNumbers(N)}");

int SumNumbers (int number)
{
    if (number == 0) return 0;
    return number % 10 + SumNumbers (number / 10);
}
