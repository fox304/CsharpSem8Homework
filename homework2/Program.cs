// Найти сумму элементов от M до N, N и M заданы
Console.OutputEncoding = System.Text.Encoding.UTF8;

int Recurse(int n,int m)
{

    if (n == m) return m;
    return m + Recurse(n,m - 1);
}
int n = 5;
int m = 20;
Console.Write("Сумма элементов от {1} до {2} равна {0}",Recurse(5,20),n,m);