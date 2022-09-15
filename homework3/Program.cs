// Найти сумму цифр числа

Console.OutputEncoding = System.Text.Encoding.UTF8;

int Recurse(int n)
{


    if (n < 10) return n;

    return Recurse(n/10)+ n%10;
}

int n = 335827;

Console.Write("Сумма цифр числа {0} равна {1} ",n,Recurse(n));
