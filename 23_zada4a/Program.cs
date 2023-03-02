// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


int Input(string a)
{
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}

double a = 0;
double i = 1;
a = Input("Введите a: ");

while (i <= a)
{
    Console.WriteLine(Math.Pow(i, 3));
    i++;
}
