// See https://aka.ms/new-console-template for more information

int number = Convert.ToInt32( Console.ReadLine());

 int calculate(int x)
{

    for (int i = 0; i < x; i++)
    {
        if (x == 1)
        {
            return 1;

        }
        else
        {
            return x * calculate(x - 1);
        }
    }
    return 0;

}

Console.WriteLine(calculate(number));
Console.ReadLine();