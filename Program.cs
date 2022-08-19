void Palindrome(int number)
{
    if (number / 10000 == number % 10)
    {
        number %= 10000;
        number /= 10;

        if (number / 100 == number % 10)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");
    }
    else
        Console.WriteLine("No");
}

int number = 14212;
Palindrome(number);

number = 12821;
Palindrome(number);

number = 23432;
Palindrome(number);