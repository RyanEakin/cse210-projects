using System;
using System.Transactions;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> NumberList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type ' 0 ' when finished.");
        int UserNumber = -1;
        int Result = 0;
        int LargestNum = 0;
        int SmallestNum = 999999999;
        string UserInput = "";

        while (UserNumber != 0)
        {
            Console.Write("Enter number: ");
            UserInput = Console.ReadLine();
            UserNumber = int.Parse(UserInput);

            if (UserNumber != 0)
            {
                NumberList.Add(UserNumber);
            }
        }
        
        
        foreach (int i in NumberList)
        {
            if (LargestNum < i)
            {
                LargestNum = i;
            }
            if (SmallestNum > i && i > 0)
            {
                SmallestNum = i;
            }

            Result += i;
        }

        double AverageNum = Queryable.Average(NumberList.AsQueryable());

        Console.WriteLine($"The sum is: {Result}");
        Console.WriteLine($"The average is: {AverageNum}");
        Console.WriteLine($"The largest number is: {LargestNum}");
        Console.WriteLine($"The smallest postive number is: {SmallestNum}");
        Console.WriteLine("The sorted list is: ");

        var SortedNumberList = NumberList.OrderBy(num => num);

        foreach (int i in SortedNumberList)
        {
            Console.WriteLine($"{i}");
        }
    }
}