//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Введите колличесво элементов маассива:");
int [] mass=new int [Convert.ToInt32(Console.ReadLine())];

Console.WriteLine("Введите элементы массива:");
for(int i=0; i<mass.Length; i++)
{
    mass[i]= Convert.ToInt32(Console.ReadLine());

}
//Console.WriteLine();
int CountEven =0;
for(int i=0; i<mass.Length; i++)
{
if (mass[i]>0)CountEven++;
}
Console.WriteLine($"{CountEven} чисел больше 0 ввёл пользователь");