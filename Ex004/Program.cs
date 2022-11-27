
Console.WriteLine("Программа для определения числа");
Console.WriteLine("Введите количество итераций");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вывод: ");
for (int i = 1; i < n+1; i++)
{   
if (i%2==0)
{
    Console.WriteLine(i);
}
}
Console.ReadKey();