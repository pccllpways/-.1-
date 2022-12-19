// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.

Console.Write("Введите элементы через пробел: ");
int count = 0;
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Элементов больше 0: {count}");
}