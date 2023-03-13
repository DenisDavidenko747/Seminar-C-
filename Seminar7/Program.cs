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

// int[,] newArray = CreateRandom2Array(rows, colums, minValue, maxValue);
// ArrayPrint2(newArray);

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
//по формуле: Aij = i + j. Выведите полученный массив на экран.

// int[,] CreatArray(int rows, int colums)
// {
//     int[,] array = new int[rows,colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = i + j;
//         }
//     } return array;
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
// Console.Write("Input a number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of collums ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreatArray(rows, colums);
// ArrayPrint2(newArray);

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] SelbstArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i += 2)
//         for(int j = 0; j < array.GetLength(1); j += 2)
//             array[i,j] *= array[i,j]; 
//         return array;    
        
// }

// int[,] CreatArray(int rows, int colums)
// {
//     int[,] array = new int[rows,colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = i + j;
//         }
//     } return array;
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
// Console.Write("Input a number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of collums ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreatArray(rows, colums);
// ArrayPrint2(newArray);
// SelbstArray(newArray);
// ArrayPrint2(newArray);

//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int GetSum(int[,] array)
// {
//     int result = 0;
//    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
//         result += array[i,i];
//         return result;
// } 

// int[,] CreatArray(int rows, int colums)
// {
//     int[,] array = new int[rows,colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = i + j;
//         }
//     } return array;
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
// Console.Write("Input a number of rows ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of collums ");
// int colums = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = CreatArray(rows, colums);
// ArrayPrint2(newArray);
// Console.WriteLine(GetSum(newArray));
