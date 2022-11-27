Console.WriteLine("Программа для поиска наибольшего числа");

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int result = Math.Max(Math.Max( a, b), c);
Console.WriteLine("Наибольшее число из трёх: "); 
Console.WriteLine( result );
