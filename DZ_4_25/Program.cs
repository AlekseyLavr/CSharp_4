// See https://aka.ms/new-console-template for more information
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int n(int a, int b) 
{
    int n = 1;
    for (int i = 0; i < b; i++)
    {
        n *= a;         
    }
    return n;
}

bool invalidB(int b)
{
    if (b < 0)
    {
        Console.WriteLine("Степень не может быть меньше нуля");
        return false;
    }
    return true;
} 

Console.Clear();
Console.Write("Введите основание: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
if (invalidB(b))
{
    Console.WriteLine($"Число {a} ввозводимое в степень {b} равно {n(a, b)}");
}


