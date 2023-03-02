// 19 задача. проверка на палиндром

int Input(string number)
{
    Console.Write(number + " ");
    return Convert.ToInt32(Console.ReadLine());
}


int a = 0;
int b = 0;
int sum = 0;
int number;
a = Input("введите пятнизначное число: ");
number = a;
while (a > 0)
{
    b = a % 10;
    sum = (sum * 10) + b;
    a = a / 10;
}
if (number == sum)
    Console.WriteLine("da");
else
    Console.WriteLine("no!");