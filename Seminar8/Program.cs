//Задача№1 Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
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

// void ChangeRows(int[,] array, int row1, int row2)
// {
//     if(row1 >= 0 && row1 < array.GetLength(0) && 
//        row2 >= 0 && row2 < array.GetLength(1)&&
//        row1 != row2)
//     {
//         for(int j =0; j < array.GetLength(1); j++)
//         {
//             int temp = array [row1, j];
//             array[row1, j] = array[row2, j];
//             array[row2, j] = temp;
//         }
//     }   
// }

// int[,] newArray = CreateRandom2Array();
// ArrayPrint2(newArray);

// Console.Write("Input row1 ");
// int r1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Input row2 ");
// int r2 = Convert.ToInt32(Console.ReadLine()) - 1;

// ChangeRows(newArray, r1, r2);
// ArrayPrint2(newArray);


// Задача№2 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// 1 2 3
// 4 5 6
// 7 8 9

// 1 4 7
// 2 5 8
// 3 6 9

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

// void ChangeRowColums(int[,] array)
// {
//     if(array.GetLength(0) == array.GetLength(1))
//     {  for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = i; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//     } else    
//         Console.WriteLine("Unable to transpose array");
           
// }

// int[,] newArray = CreateRandom2Array();
// ArrayPrint2(newArray);
// ChangeRowColums(newArray);
// ArrayPrint2(newArray);


// Задача№3 Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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


// int[] FindMin(int[,] array)
// {
//     int[] result = new int[2];
   
//     for(int i = 0; i < array.GetLength(0); i++)
//         for(int j = 0; j < array.GetLength(1); j++)
//             if(array[i,j] < array[result[0], result[1]])
//             {
//                 result[0] = i;
//                 result[1] = j;
//             }
//         return result;
        
    
// }

// int[,] RemoveRowAndColums(int[,] array, int row, int col)
// {
//     int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
    
//     for(int i = 0, newI = 0; i < array.GetLength(0); i++)
//         if (i != row)
//         {
//         for(int j = 0, newJ =0; j < array.GetLength(1); j++)
//             if(j != col)
//             {
//                 result[newI, newJ] = array[i, j];
//                 newJ++;
//             }
//         newI++;        
//         } return result;        
// } 

// int[,] array = CreateRandom2Array();
// ArrayPrint2(array);
// int[] minPosition = FindMin(array);
// int[,] newArray = RemoveRowAndColums(array, minPosition[0], minPosition[1]); 
// ArrayPrint2(newArray);