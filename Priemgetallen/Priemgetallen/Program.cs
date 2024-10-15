for(int number = 1; number <= 100; number++)
{
    bool isPrimeNumber = true;

    for(int check = 2; check <= (number / 2); check++)
    {
        if (number % check == 0)
        {
            isPrimeNumber = false;
        }
    }

    if (isPrimeNumber && number != 1)
        Console.ForegroundColor = ConsoleColor.Red;
    else
        Console.ForegroundColor = ConsoleColor.Green;


    Console.Write($"{number}\t");

    Console.ResetColor();

    if(number % 10 == 0)
    {
        Console.WriteLine();
    }
}
