//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
//точек в этой четверти (x и y).

// void ShowDiapozone(int quad)
// {
//     if(quad == 1) Console.WriteLine("x > 0 and y > 0");
//     else if (quad == 2) Console.WriteLine("x < 0 and y > 0");
//     else if (quad == 3) Console.WriteLine("x < 0 and y < 0");
//     else if (quad == 4) Console.WriteLine("x > 0 and y < 0");
//     else Console.WriteLine("Uncorrect input!");
// }
// Console.Write("Input a number quadrant: ");
// int quadrant = Convert.ToInt32(Console.ReadLine());

// ShowDiapozone(quadrant);

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём
// X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int QuadDeterm(int x, int y)
// {
//     int quad = 0;

//     if(x > 0 && y >0) quad = 1;
//     else if(x < 0 && y > 0) quad = 2;
//     else if(x < 0 && y < 0) quad = 3;
//     else if(x > 0 && y < 0) quad = 4;

//     return quad;
// }

// Console.Write("Input point coordinate X: ");
// int pointX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input point coordinate Y: ");
// int pointY = Convert.ToInt32(Console.ReadLine());

// int quad = QuadDeterm(pointX, pointY);

// Console.WriteLine($"Point with coordindtes ({pointX}:{pointY}) is in {quad} quadrant ");


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Distance(double xA, double yA, double xB, double yB)
// {
//     double hypotenuse = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
//     return hypotenuse;
// }

// Console.Write("Input point coordinate xA: ");
// double pointxA = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point coordinate yA: ");
// double pointyA = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point coordinate xB: ");
// double pointxB = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input point coordinate yB: ");
// double pointyB = Convert.ToDouble(Console.ReadLine());

// double lenght = Distance(pointxA, pointyA, pointxB, pointyB);

// Console.WriteLine($"Distance between point A({pointxA}:{pointyA}) & point b({pointxB}:{pointyB})");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void TablePrint(int num)
// {
//     int current = 1;

//     while(current < num)
//     {
//         Console.WriteLine(current + " " + Math.Pow(current, 2));
//         current++;
//     }
// }

// Console.WriteLine("Enter your number");
// int number = Convert.ToInt32(Console.ReadLine());

// TablePrint(number);

