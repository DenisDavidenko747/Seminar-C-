﻿// Console.Write("Input a forst number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// // int max = 0;
// // int min = 0;

// if(num1 > num2)
// {
//     // max = num1;
//     // min = num2;
//     Console.WriteLine("Max= " + num1 + " Min= " + num2);
// }
// else
// {
//     //  max = num2;
//     //  min = num1;
//     Console.WriteLine("Max= " + num2 + " Min= " + num1);
// }

// // Console.WriteLine("Max= " + max + " Min= " + min);

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Write("Input a forst number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a last number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if(num2 > max)
// {
//     max = num2;
// }
// if(num3 > max)
// {
//     max = num3;
// }

// Console.WriteLine(max);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num % 2 == 0 )
// {
//     Console.WriteLine("Да ");
// } 
// else
// {
//     Console.WriteLine("Нет ");
// }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;
while(i <= N)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
        i++;
    }
    else
    {
        i++;
    }
}