// Задача 64. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5-> "5, 4, 3, 2, 1"
// N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"


void ShowSubsequence(int N, int M)
{
    Console.Write($"{N} ");
    if (N < M)
    {
        ShowSubsequence(N + 1, M);
    }
    else if (N > M)
    {
        ShowSubsequence(N - 1, M);
    }
}

Console.WriteLine("Введите целое число N=");
int N = Convert.ToInt32(Console.ReadLine());
ShowSubsequence(N, 1);


// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начальное натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конечное натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Sum(int start, int stop)
{
    if (start != stop + 1) return start + Sum(start + 1, stop);
    else return 0;
}
Console.WriteLine("Cумма натуральных элементов в промежутке от M до N");
Console.WriteLine(Sum(numberM, numberN));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите неотрицательные число m: ");
double numberM = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите неотрицательные число n: ");
double numberN = Convert.ToDouble(Console.ReadLine());

double Akkerman(double m, double n)
{
    if (m == 0) return n + 1;

    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);

    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;

}

Console.WriteLine(Akkerman(numberM, numberN));