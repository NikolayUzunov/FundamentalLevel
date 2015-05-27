using System;

class ReverseNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(number);
        Console.WriteLine(reversed);
    }
    static double GetReversedNumber(double number)
    {
        return double.Parse(ReverseString(number.ToString()));
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

