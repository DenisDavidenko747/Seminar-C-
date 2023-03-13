// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int Positive(int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0)
//         {
//         count = count++;
//         }
        
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//         Console.WriteLine();
        
// }

// int[] CreateArray(int m)
// {
//      int[] array = new int[m];

//      for(int i = 0; i < array.Length; i++)
//         {
//             Console.Write("Input array[i]: ");
//             array[i] = Convert.ToInt32(Console.ReadLine());     
//         } 
//         return array;
//  } 

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateArray(m);
// PrintArray(newArray);
// Console.WriteLine(Positive(CreateArray(m)));


//Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");