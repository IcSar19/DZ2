Console.Clear();

Console.Write("Введите любое число");
int a = Int32.Parse(Console.ReadLine() ?? "0");

if (a < 100)
{
    Console.Write("Число меньше 100");
}
else
{
    while (a > 1000)
    {
        a /= 10;
    }
    Console.WriteLine(a % 10);
}