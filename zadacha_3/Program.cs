int a = 12564;
Console.WriteLine(a);
if (a > -100 && a < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else
{
    while (a > 1000)
    {
      a = a / 10;
    }
    Console.WriteLine(a % 10);
}
