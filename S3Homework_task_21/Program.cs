// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите координату x(A) ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y(A) ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z(A) ");
double zA = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату x(B) ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y(B) ");
double yB = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату z(B) ");
double zB = Convert.ToDouble(Console.ReadLine());

double s = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round (s, 2)}");