//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

// int Quantity(int[] array)
// {   
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//         if(array[i] % 2 == 0) count++;
//     return count;    

// }

// int[] newArray = {345, 897, 568, 234};
// PrintArray(newArray);
// int result = Quantity(newArray);
// Console.WriteLine(result);

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

// int SumEvenNumbers(int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i = i + 2) 
//     sum = sum + array[i];
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

// int result = SumEvenNumbers(newArray);
// Console.WriteLine(result);

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// float[] CreateRandomArray(int size, float minValue, float maxValue)
// {
//     float[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
        
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++) 
    {
        if(array[i] > max)
        {
            max = array[i];
            
            
        }
        if(array[i] < min)
        {
            min = array[i];
            
        }
    }
    Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
    
}

double[] newArray = {3, 7, 22, 2, 78};
PrintArray(newArray);
double result = Difference(newArray);
Console.WriteLine(result);

