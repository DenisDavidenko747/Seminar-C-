// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Degree( int a, int b)
// {
//      int degree = a;
    
//      for( int i = 1; i < b; i++ )
//      {
//          degree = degree * a;
//      }
//      return degree;
// }

// Console.WriteLine("Введи число А");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введи число B");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = Degree(a, b);
// Console.WriteLine("A в степени B равно: " + result);

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("Введи число ");
// int i = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (i > 0)
// {
//     int num = i % 10;
//     i = i / 10;
//     sum = sum + num;
// }

// Console.WriteLine("сумма всех цифр в числе равна: " + sum); 

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int m)
{
    int[] array = new int[m];

     for(int i = 0; i < m; i++)
    {
     Console.Write("Input a elements: ");
     int num = Convert.ToInt32(Console.ReadLine());

     array[i] = num;
    } return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();
        
}

Console.Write("Input a quallity of elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(m);
PrintArray(newArray);