// a = 2, b = 3, c = 7
// a = 44, b = 5, c = 78
// a = 22, b = 3, c = 9

Console.WriteLine("Напишите первое число");
string str = Console.ReadLine();
int a = int.Parse(str);
Console.WriteLine("Напишите второе число");
str = Console.ReadLine();
int b = int.Parse(str);
Console.WriteLine("Напишите третье число");
str = Console.ReadLine();
int c = int.Parse(str);
int max = int.Parse(str);
if(a > b)
{
    a = max;
}
else
{
    b = max;
}
if(b > c)
{
    b = max;
}
else
{
    c = max;
}
if(c > a)
{
    c = max;
}
else
{
    a = max;
}
Console.WriteLine("максимальное число " + max);