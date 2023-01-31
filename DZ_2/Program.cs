//   Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int len(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

int summary(int a)
{
    int result = 0;
    int dlina = len(a);
    for (int i = 0; i < dlina; i++)
    {
        result += a % 10;
        a /= 10;
    }
    return result;
}

Console.Write("Введите  А: ");
int a = int.Parse(Console.ReadLine()!);
int sum = summary(a);
Console.WriteLine($"{sum}");