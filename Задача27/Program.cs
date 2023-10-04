int promt(string message)
{
    Console.Write("Введите число");
    string.readInput = Console.ReadLIne();
    int result = int.Parse(readinput);
    return result;
}

int amount(int num)
{
    int res = 0;
    while (num > 0)
    {
        res += num % 10;
        num = num / 10;
    }
    return res;
}

int number = promt;
Console.WriteLine (amount(number));
