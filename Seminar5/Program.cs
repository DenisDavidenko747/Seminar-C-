 // Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

//  int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
        
// }

// int GetNegativeSum(int[] array)
// {
//     int sum = 0;

//     for(int i = 0; i < array.Length; i++)
    
//         if(array[i] < 0)
//             sum += array[i];
    
//     return sum;
// }

// Console.Write("Input a quallity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(size, min, max);
// PrintArray(newArray);

// int result = GetNegativeSum(newArray);
// Console.WriteLine("Sum of negativs is " + result);

// Напишите программу заменs элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
        
// }

// int[] ChangePosition(int[] array)
// {
//     for(int i = 0; i< array.Length; i++)
//     {
//       array[i] *= -1;
                  
//     }
//     return array;
// }


// int[] newArray = CreateRandomArray(12, -9, 9);
// PrintArray(newArray);
// PrintArray(ChangePosition(newArray));


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
        
// }

// bool FindNumberInArray(int[] array, int number)
// {
//     for(int i = 0; i < array.Length; i++)
   
//         if(array[i] == number)
//         return true;
  
//     return false;
    
// }

// int[] newArray = CreateRandomArray(12, -9, 9);
// PrintArray(newArray);
// bool result = FindNumberInArray(newArray, 12);
// Console.WriteLine(result);

//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

// int[] CreateRandomArray(int m, int minValue, int maxValue)
// {
//     int[] array = new int[m];

//     for(int i = 0; i < m; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
        
// }

// int HowManyNumbers(int[] array, int a, int b)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
    
//         if(array[i] >= a && array[i] <= b) count++;
         
//     return count;
    
// }

// int[] newArray = CreateRandomArray(12, -9, 9);
// PrintArray(newArray);
// int result = HowManyNumbers(newArray, -9, 9);
// Console.WriteLine(result);

