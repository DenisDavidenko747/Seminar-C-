// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] CreateRandom2Array()
// {
//     Console.Write("Input a number of rows ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of collums ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of minValue ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of maxValue ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int [rows, colums];

//     for(int i = 0; i < rows; i++)
//     { 
        
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void ArrayPrint2(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//        for(int j = 0; j < array.GetLength(1); j++) 
//        {
//         Console.Write(array[i,j] + " ");
//        }
//        Console.WriteLine();
//     }
    
//     Console.WriteLine();
// }

// void OrderedArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1) - 1; j++)
//         {
//             for(int y = 0; y < array.GetLength(1) - 1; y++)
//             {
//                 if(array[i, y] < array[i, y + 1])
//                 {
//                     int temp = 0;
//                     array[i, y] = array[i, y + 1];
//                     array[i, y + 1] = temp;
//                 }
//             }
//         }
//     }
// }

// int[,] array = CreateRandom2Array();
// ArrayPrint2(array);
// OrderedArray(array);
// ArrayPrint2(array);

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateRandom2Array()
// {
//     Console.Write("Input a number of rows ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of collums ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of minValue ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of maxValue ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
//     int[,] array = new int [rows, colums];

//     for(int i = 0; i < rows; i++)
//     { 
        
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void ArrayPrint2(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//        for(int j = 0; j < array.GetLength(1); j++) 
//        {
//         Console.Write(array[i,j] + " ");
//        }
//        Console.WriteLine();
//     }
    
//     Console.WriteLine();
// }

// void ArrayLineSum(int[,] array)
// {
    
//     int minsum = 0;
//     int indexLine = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         if(sum < minsum)
//         {
//             minsum = sum;
//             indexLine++;
//         }
//     } Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum)); 
    
// }

// int[,] newArray = CreateRandom2Array();
// ArrayPrint2(newArray);
// ArrayLineSum(newArray);

// Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] CreateRandom2Array(int[,] array)
// {
//     Console.Write("Input a number of rows ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of collums ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of minValue ");
//     int minValue = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input a number of maxValue ");
//     int maxValue = Convert.ToInt32(Console.ReadLine());
    
//     for(int i = 0; i < rows; i++)
//     { 
        
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void ArrayPrint2(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//        for(int j = 0; j < array.GetLength(1); j++) 
//        {
//         Console.Write(array[i,j] + " ");
//        }
//        Console.WriteLine();
//     }
    
//     Console.WriteLine();
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int size = InputInt("размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// CreateRandom2Array(matrixA);
// CreateRandom2Array( matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// ArrayPrint2(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// ArrayPrint2(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// ArrayPrint2(matrixC);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// void ArrayPrint2(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//        for(int j = 0; j < array.GetLength(1); j++) 
//        {
//         Console.Write(array[i,j] + " ");
//        }
//        Console.WriteLine();
//     }
    
//     Console.WriteLine();
// }


   
//     Console.WriteLine("Введите размер массива");
//     int size = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[size, size];

//     int num = 1;
//     int i = 0;
//     int j = 0;
//     while (num <= size * size)
//     {
//         array[i, j] = num;
//         if (i <= j + 1 && i + j < size - 1)
//         ++j;
//         else if (i < j && i + j >= size - 1)
//         ++i;
//         else if (i >= j && i + j > size - 1)
//         --j;
//         else
//         --i;
//         ++num;
//     }

// ArrayPrint2(array);


