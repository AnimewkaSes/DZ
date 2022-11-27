
Console.WriteLine("Программа для поиска наибольшего числа");
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int result = Math.Max( a, b);
Console.WriteLine("Наибольшее число из двух: "); 
Console.WriteLine( result );