// Задача 68: Напишите метод вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите число M");
bool isParsedM = double.TryParse(Console.ReadLine(), out double m);
Console.WriteLine("Введите число N");
bool isParsedN = double.TryParse(Console.ReadLine(), out double n);
if (!isParsedM || !isParsedN || m < 0 || n < 0)
{
    Console.WriteLine("Ошибка!");
    return;
}
double ackermanFunction = AckermanFunction(m, n);
Console.WriteLine(ackermanFunction);
double AckermanFunction(double m, double n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
