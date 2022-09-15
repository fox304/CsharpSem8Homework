// Написать программу показывающие первые N чисел,
// для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

Console.OutputEncoding = System.Text.Encoding.UTF8;


int Recurse(int num1,int num2,int n)
{
    if (n == 1) return num2;
    if (n == 0) return num1;
    return Recurse(num1,num2,n - 1)+Recurse(num1,num2,n - 2);
}
Console.WriteLine("ВВедите первый элемент последовательности");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите второй элемент последовательности");
int num2 = Convert.ToInt32(Console.ReadLine());;
int n = 8;                      // колличество чисел которые нужно вывести

Console.WriteLine("Первые {2} элементов последовательности  с начальными числами {0} и {1} будут такие",num1,num2,n);
for (int i = 0; i < n; i++)
{
    Console.Write("{0}  ",Recurse(num1,num2,i));
}





