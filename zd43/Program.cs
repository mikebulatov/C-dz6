

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Введите k1:");
int k1=Convert.ToFloat(Console.ReadLine());
Console.Write("Введите b1:");
int b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2:");
int k2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2:");
int b2=Convert.ToInt32(Console.ReadLine());

float x = (b2-b1)/(k1-k2);
float y = k1*(b2-b1)/(k1-k2)+b1;

Console.WriteLine($"Координаты точки пересечения функций y={k1}x+{b1} и y={k2}x+{b2} это x={x} y={y}");