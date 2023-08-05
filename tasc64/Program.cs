//Задайте значения N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int NatNumber(int n, int a)
{
    if(n == a) return n;
    else
    {
        Console.Write($"{NatNumber(n, a + 1)}, ");
        return a;
    }
}

int Number(string text)
{
    Console.Write(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int n = Number("Введите число:\n");
int a =1;
Console.Write($"{n} => "); 
Console.WriteLine(NatNumber(n, a));
