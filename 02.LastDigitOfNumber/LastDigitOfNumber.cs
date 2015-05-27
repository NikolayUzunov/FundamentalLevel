using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(number));
    }

    private static string GetLastDigitAsWord(int num )
    {
        string[] digitAsWord = { "zero", "one", "two", "three", "four",
                                "five", "six", "seven", "eight", "nine" };
        int digit = num%10;
        return digitAsWord[digit];
    }
}

