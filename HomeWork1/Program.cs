// Console.Write("Input a forst number: ");
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

Console.Write("Input a forst number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a last number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
{
    max = num2;
}
if(num3 > max)
{
    max = num3;
}

Console.WriteLine(max);