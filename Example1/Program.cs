Console.Clear();

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

a = a / 10;
a = a % 10;

Console.WriteLine(a);