
Console.WriteLine("Программа для определения числа");
double number = Convert.ToDouble(Console.ReadLine());
//double result = number/2;
if (number%2==0)
{
    Console.WriteLine("Чётное");
}else{
    Console.WriteLine("Не чётное");
}
Console.ReadKey();
