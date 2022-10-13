// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int x = Convert.ToInt32(Console.ReadLine());
void Descending (int x)
{
    if (x > 0)
    {
        Console.Write($"{x}; ");
        Descending(x-1);
    }
}
Descending(x);