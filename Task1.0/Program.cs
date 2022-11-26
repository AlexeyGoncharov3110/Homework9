// Задайте значение N. Напишите метод, 
// который выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.WriteLine("Введите число N");
bool isParsedN= int.TryParse(Console.ReadLine(), out int n);
if(!isParsedN || n<=0)
{
    Console.WriteLine("Ошибка!");
    return;
}
AllNumber(n);
void AllNumber(int n, int m=1)
{
    if(n>=m)
    {
        Console.Write($"{n},");
        AllNumber(n-1);
    }
}

