// Написать программу возведения числа А в целую стень B
Console.OutputEncoding = System.Text.Encoding.UTF8;

int Recurse(int a,int b)
{

    if (b == 1) return a;
    return Recurse(a,b - 1)*a;
}

int a = 2;
int b = 10;
Console.Write("Число {0} в степени {1} будет равно {2} ",a,b,Recurse(a,b));
