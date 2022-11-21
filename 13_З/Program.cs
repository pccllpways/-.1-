// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int number = int.Parse(str);
int number1 = 100;
int number2 = 1000;
int number3 = 10000;
int number4 = 100000;
int number5 = 1000000;
int number6 = 10000000;
int number7 = 100000000;
int number8 = 1000000000;
if (number < number1)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (number < number2)
{
    Console.WriteLine("Третья цифра числа: " + number % 10);
}
else if (number < number3)
{
    number = number % 100;
    Console.WriteLine("Третья цифра числа: " + number / 10);
}
else if (number < number4)
{
    number = number / 100;
    Console.WriteLine("Третья цифра числа: " + number % 10);
}
else if (number < number5)
{
    number = number / 1000;
    Console.WriteLine("Третья цифра числа: " + number % 10);
}
else if (number < number6)
{
    number = number / 10000;
    Console.WriteLine("Третья цифра числа: " + number % 10);
}
else if (number < number7)
{
    number = number / 100000;
    Console.WriteLine("Третья цифра числа: " + number % 10);
}
else if (number < number8)
{
    number = number / 1000000;
    Console.WriteLine("Третья цифра числа: " + number % 10);
}
else if (number > number8)
{
    Console.WriteLine("Величина числа превышена");
}