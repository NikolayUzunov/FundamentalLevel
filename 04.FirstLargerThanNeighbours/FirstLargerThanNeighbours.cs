using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
        int indexFirstLarger = GetFirstElementLargerThanNeighbours(numbers);
        Console.WriteLine(indexFirstLarger);
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        if (i == 0)
        {
            if (numbers[0] > numbers[1])
                return true;
            else
            {
                return false;
            }
        }
        if (i == numbers.Length - 1)
        {
            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                return true;
            else
            {
                return false;
            }
        }
        if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            return true;
        else
        {
            return false;
        }
    }

    private static int GetFirstElementLargerThanNeighbours(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (IsLargerThanNeighbours(array, i))
            {
                return i;
            }
        }
        return -1;
    }
}

