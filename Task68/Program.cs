// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akker(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akker(m - 1, 1);
  else return Akker(m - 1, Akker(m, n - 1));
}

int akkerman = Akker(m, n);
Console.WriteLine($"Функция Аккермана = {akkerman}");