// Задайте значения M и N. Напишите метод,
// который найдёт сумму натуральных элементов
// в промежутке от M до N.Через рекурсию!
Console.WriteLine("Введите число M");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число N");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);
if (!isParsedM || !isParsedN || m < 0 || n < 0 || m > n)
{
    Console.WriteLine("Ошибка!");
    return;
}
int sumOfNumbersBetween = SumOfNumbersBetween(m, n);
Console.WriteLine(sumOfNumbersBetween);
int SumOfNumbersBetween(int m, int n, int sum = 0)
{
    if (m == n)
    {
        return n;
    }
    return m + SumOfNumbersBetween(m + 1, n);
}
