// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

Console.WriteLine("Введите цифру дня недели: ");
string str = Console.ReadLine();
int number = int.Parse(str);
if (number > e)
{
    Console.WriteLine("Это выходной день недели:)");
}
else
{
    Console.WriteLine("Это рабочий день недели:(");
}
