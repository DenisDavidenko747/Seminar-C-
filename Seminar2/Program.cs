//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;
//     int result = hundreds * 10 + units;

//     return result;
// }

// int randNumber = new Random().Next(100,1000);
// int newNumber = CutNumber(randNumber);
// Console.WriteLine($"New version of {randNumber} is {newNumber}");

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

// bool IsMultiplyed(int num, int div1, int div2)
// {
//      if(num % div1 ==0 && num % div2 ==0)
//     // if(num % (div1 * div2) ==0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// bool IsMultiplyedBest(int num, int div1, int div2) // альтернатива
//{
//  retutn num % div1 ==0 && num % div2 ==0;
//}

// Console.Write("Input a  number for checking: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a first divider ");
// int divider1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second divider ");
// int divider2 = Convert.ToInt32(Console.ReadLine());

// bool result = IsMultiplyed(num, divider1, divider2);
// // Console.WriteLine(result);
// if(result)
// {
//     Console.WriteLine($"Your number {num} is divisible by the {divider1} and {divider2} ");
// }
// else
// {
//     Console.WriteLine($"Your number {num} is not divisible by the {divider1} and {divider2} ");
// }

// Задача 1: Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.int 
                      
// int  maxDigit(int num)
// {
//     int digit1 = num / 10;
//     int digit2 = num % 10;

//     if(digit1 > digit2)
//     {
//         return digit1;
//     }
//     else
//     {
//         return digit2;
//     }
// }

// int randNumber = new Random().Next(10,100);
// int result = maxDigit(randNumber);

// Console.WriteLine($"Max digit in number {randNumber} is {result} ");



// Задача 2: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// bool isQuad(int num1, int num2)
// {
//     return  num1 == num2 * num2 || num2 == num1 * num1;
// }

// Console.Write("Input a first number" );
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool result = isQuad(num1, num2);

// Console.WriteLine(result);

