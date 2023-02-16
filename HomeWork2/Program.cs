//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int result = ((num / 10) % 10);
//     return result;
// }

// Console.Write("Input a three - digit number " );
// int num = Convert.ToInt32(Console.ReadLine());

// int result = CutNumber(num);
// Console.WriteLine(result);

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// int CutNumber2(int num)
// {
//     int count = 0;
//     while (num > 0)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }

// Console.Write("Input a number " );
// int num = Convert.ToInt32(Console.ReadLine());
// int resultCutNumber = CutNumber2(num);

// if(resultCutNumber <= 2)
// {
//     Console.WriteLine("третьей цифры нет ");
// }
// else
// {
//     if(resultCutNumber == 3) {
//         int result = num % 10;
//         Console.WriteLine($"Третья цифра {result} ввели: {num} Колличество цифр в переменной {resultCutNumber}");
        
//     }
//     else
//     {
//         int result = ((num / 100) % 10);
//         Console.WriteLine($"Третья цифра {result} ввели: {num} Колличество цифр в переменной {resultCutNumber}");
//     }
      
    
// }    
    

//Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7 ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <=7)
{
    if(num == 6 | num == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else
{
    Console.WriteLine("Ошибка формата числа");
}
