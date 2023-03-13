// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
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


// Console.WriteLine("введите количество строк");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Console.WriteLine("введите a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите b");
// int b = Convert.ToInt32(Console.ReadLine());

// void ArrayShow(int[,] array, int a, int b)
// {
//     if(a > array.GetLength(0) || b > array.GetLength(1))
//     {
//         Console.WriteLine("такого элемента нет");
//     }
//     else
//     {
//         Console.WriteLine($"значение элемента {a} строки и {b} столбца равно {array[a-1,b-1]}");
//     }
// }

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

// int[,] newArray = CreateRandom2Array();
// ArrayPrint2(newArray);
// ArrayShow(newArray, a, b);


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}