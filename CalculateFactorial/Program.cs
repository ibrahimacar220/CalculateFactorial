// See https://aka.ms/new-console-template for more information

int number = Convert.ToInt32( Console.ReadLine());

int Calculate(int x)
{
    if (x == 0 || x == 1)
    {
        return 1;
    }
    else
    {
        return x * Calculate(x - 1);
    }
}

Console.WriteLine(Calculate(number));
Console.ReadLine();