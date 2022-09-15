// Показать натуральные числа от M до N, N и M  заданы
Console.OutputEncoding = System.Text.Encoding.UTF8;

void Recurse(int n,int m)
{
    if (m < n) return;
    Recurse(n,m-1);
    Console.Write("{0} ",m);
}


Recurse(5,50);
