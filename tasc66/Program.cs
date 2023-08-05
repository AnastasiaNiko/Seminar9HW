//Задайте значение M и N. Напишите программу, которая найдет
//сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

int m = Number("Введите значение M: ");
int n = Number("Введите значение N: ");
Console.WriteLine($"M={m}; N={n} -> {NatNumber(m, n)}");

int Number(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int NatNumber(int m, int n)
{
    if(m == n) return n;
    return n + NatNumber(m, n - 1);   
}