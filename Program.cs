// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// int rows = 4;
// int columns = rows;
// int [,] result = new int [rows,columns];

// void GetArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = new Random().Next(0,10);
//         } 
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//        {
//         Console.Write(result[i,j]);
//        }

//        Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ArraySort()
// {
//     {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {   
//         int temp;
//         bool check = true;
//         while (check)
//         {
//             check = false;
//             for (int j = 0; j < result.GetLength(1) - 1; j++)
//             {
//                 if (result[i,j] < result[i,j+1])
//                 {
//                     temp = result[i,j];
//                     result[i,j] = result[i,j+1];
//                     result[i,j+1] = temp;
//                     check = true;
//                 }
//             }
//         } 
//     }
// }
// }
// GetArray();
// PrintArray();
// ArraySort();
// PrintArray();

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// int rows = 3;
// int columns = 4;
// int [,] result = new int [rows,columns];
// void GetArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = new Random().Next(0,10);
//         } 
//     }
// }
// void PrintArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//        {
//         Console.Write(result[i,j]);
//        }

//        Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ArrayCheck()
// {
//     int line = 0;
//     int minSum = int.MaxValue;
//     {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         int Sum = 0;
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             Sum += result[i,j];
//         } 
//         if (Sum < minSum)
//         {
//             minSum = Sum;
//             line = i;
//         }
//     }
//     System.Console.WriteLine($"Line {line + 1} with minimal sum ={minSum}");
// }
// }
// GetArray();
// PrintArray();
// ArrayCheck();

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Работает только с одинаковыми матрицами
// int [,] result = new int [,] { 
//     {2,4,3},
//     {3,2,2},
//     {1,2,3}
// };

// int [,] result2 = new int [,] { 
//     {3,4,1},
//     {3,3,2},
//     {3,2,1}
// };
// int [,] array = new int [result.GetLength(0),result.GetLength(1)];

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//        {
//         Console.Write(array[i,j]+ " ");
//        }
//        Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void Multipl()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//             for (int j = 0; j < result.GetLength(1); j++)
//             {
//             //   array[i,j] = result[i,0] * result2[0,j] + result[i,1] * result2[1,j];
//                 array[i,j] = 0;
//                 int n = 0;
//                 while (n != result.GetLength(0))
//                 {
//                     array[i,j] = array[i,j] + result[i,n] * result2[n,j];
//                     n++;
//                 }
//             }
//         }
// }
// PrintArray(result);
// PrintArray(result2);
// Multipl();
// PrintArray(array);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// int [,,] result = new int [3,5,6];
// void fillArray()
// {   int number = 9;
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(2); k++)
//             {
//                 result[i,j,k] = number +1;
//                 number++;
//             }
//         }
//     }
// }
// void printArray()
// {
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             for (int k = 0; k < result.GetLength(2); k++)
//             {
//                 System.Console.WriteLine($"{result[i,j,k]}({i},{j},{k})");
//             }
//         }
//     }
// }
// fillArray();
// printArray();
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// int[,] array = new int[4,4];

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//        {
//         Console.Write(array[i,j]+ " ");
//        }
//        Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void FillArray()
// {   
//     int i = 0;
//     int j =0;
//     int num = 0;
    
//     for (j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = num + 1;
//         num ++;
//     }
//     j = j - 1;
//     for (i =1; i < array.GetLength(0); i++)
//     {
//         array[i,j] = num +1;
//         num++;
//     }
//     i=i-1;
//     for (j = array.GetLength(1)-2; j >= 0;j--)
//     {
//         array[i,j] = num +1;
//         num++;
//     }
//     j=j+1;
//     for (i = array.GetLength(0)-2; i > 0; i--)
//     {
//         array[i,j] = num +1;
//         num++;
//     }
//     i=i+1;
//     for (j = 1; j <= array.GetLength(1)-2; j++)
//     {
//         array[i,j] = num + 1;
//         num ++;
//     }
//     j=j-1;
//     for (i =2; i <= array.GetLength(0)-2; i++)
//     {
//         array[i,j] = num +1;
//         num++;
//     }
//     i=i-1;
//     for (j = array.GetLength(1)-3; j > 0;j--)
//     {
//         array[i,j] = num +1;
//         num++;
//     }
// }
// PrintArray(array);
// FillArray();
// PrintArray(array);
