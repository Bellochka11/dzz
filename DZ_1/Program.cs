// // Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать библиотеку Math!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int Degree(int a, int b)
{
    int result = 1;
    for (int i = 0; i <= b; i++)
    {
        result *= a;
    }
    return result;
}

Console.Write("Введите  А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите B: ");
int b = int.Parse(Console.ReadLine()!);
int num_degree = Degree(a,b);
Console.WriteLine($"{num_degree}");
