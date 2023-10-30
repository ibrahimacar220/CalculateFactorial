// See https://aka.ms/new-console-template for more information

int number = Convert.ToInt32( Console.ReadLine());

int calculate(int x)
{
    if (x == 0 || x == 1)
    {
        return 1;
    }
    else
    {
        return x * calculate(x - 1);
    }
}

Console.WriteLine(calculate(number));
Console.ReadLine();