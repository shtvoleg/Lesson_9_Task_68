// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int m, int n)                                      // метод находит значения функции Аккермана с помощью рекурсии
{
    if (m == 0)                                                 //  условие выхода из рекурсии
        return n + 1;
    else
        if (m != 0 && n == 0)
        return Ackerman(m - 1, 1);
    else
        return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.Clear();				                                //  очистка консоли
Console.WriteLine("Введите число m: ");	                        //  запрос первого числа
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");	                        //  запрос второго числа
int n = Convert.ToInt32(Console.ReadLine());
if (m > 0 && n > 0)
    Console.WriteLine($"Функция Аккермана для аргументов {m} и {n} равна: {Ackerman(m, n)}.");
else
    Console.WriteLine("Числа m и n должны быть больше 0.");