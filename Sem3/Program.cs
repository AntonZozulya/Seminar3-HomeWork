// Семинар 3, работа с преподователем

//Напишите программу, которая будет находить сумму цифр числа

// Console.Clear();
// string s = Console.ReadLine()!;
// int sum = 0;
// for (int i =0; i < s.Length; i++)
//     sum = sum + int.Parse(s[i].ToString());
// Console.WriteLine(sum);



//ЗАДАЧА №17 Напишите программу, которая принемает на вход кординаты точки 
//(Х и У), причем Х !=0 и У != 0 и выдает номер четверти 
//плоскости, в которой находится эта точка

// Console.Clear();
// Console.Write("Введите координату X: ");
// double x = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// double y = Convert.ToDouble(Console.ReadLine());
// while (x == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите координату X: ");
//     x = Convert.ToDouble(Console.ReadLine());
// }
// while (y == 0)
// {
//     Console.Write("Вы ошиблись!\nВведите координату Y: ");
//     y = Convert.ToDouble(Console.ReadLine());
// }
// if (x > 0 && y > 0)
//     Console.WriteLine("I");
// else if (x < 0 && y > 0)
//     Console.WriteLine("II");
// else if (x < 0 && y < 0)
//     Console.WriteLine("III");
// else
//     Console.WriteLine("IV");



//ЗАДАЧА №18 Напишите программу, которая по заданному номеру четверти, 
//показывет диапазон возможных кординат в этой четверти (Х и У)

// Console.Clear();
// Console.Write("Введите номер четверти: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 1 || n > 4)
// {
//     Console.Write("Вы ошиблись!\nВведите номер четверти: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// if (n == 1)
//     Console.WriteLine("x > 0 and y > 0");
// else if (n == 2)
//     Console.WriteLine("x < 0 and y > 0");
// else if (n == 3)
//     Console.WriteLine("x < 0 and y < 0");
// else
//     Console.WriteLine("x > 0 and y < 0");


//ЗАДАЧА №21 Напишите программу, которая принемает на вход
//кординаты двух точек и находит растояние между ними в 2D пространстве

// Console.Clear();
// Console.Write("Введите координату X(1): ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y(1): ");

// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату X(2): ");

// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координату Y(2): ");

// double y2 = Convert.ToDouble(Console.ReadLine());
// double s = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2));
// Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 2)}");



//ЗАДАЧА №22 Напишите программу, которая принемает на вход
//число (N) и выдает таблицу квадратов чисел от 1 до N

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= n; i++)
//     Console.WriteLine($"{i} ^ 2 = {i * i}");