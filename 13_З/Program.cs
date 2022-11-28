// Задача 13: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int number = int.Parse(str);

if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int three = number % 10;
    Console.WriteLine("Третья цифра числа: " + number);
}
else
{
    Console.WriteLine("Третьеё цифры нет");
}
