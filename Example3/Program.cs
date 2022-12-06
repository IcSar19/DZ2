Console.Clear();

Console.WriteLine("Введите день недели");
int d = int.Parse(Console.ReadLine());

if ((d < 1) || (d > 7))
{
    Console.WriteLine("Введен неверный день");
    return;
}
else
{
    if (d > 5)
    {
        Console.WriteLine("Сегодня выходной");
    }
    else
    {
        Console.WriteLine("Сегодня будний день");
    }
}