// Написать программу вычисления функции Аккермана
/*

                    | n + 1                 m = 0
            A(m,n)  | A(m -1,1)             m > 0 , n = 0
                    | A(m - 1,A(m,n - 1))   m > 0 , n > 0

*/
Console.OutputEncoding = System.Text.Encoding.UTF8;

int Recurce(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Recurce(m - 1, 1);
    return Recurce(m - 1,Recurce(m,n - 1));
}
Console.Write(Recurce(2,3));

