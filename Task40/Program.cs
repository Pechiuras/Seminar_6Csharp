// Task40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины
Console.Clear();
Console.WriteLine("Введите длину стороны 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны 3: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && b + c > a && c + a > b)
Console.WriteLine("Такой треугольник существует");
else
Console.WriteLine("Ошибка");