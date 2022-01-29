using System;
using System.Linq;
using System.Collections.Generic;

class LinqProgram
{
    static void Main(string[] args)
    {
        string input_str;

        Console.WriteLine("Input the string : ");
        input_str = Console.ReadLine();

        var Freq = from x in input_str
                        group x by x into y
                        select y;
        Console.Write("The frequency of the characters are :\n");
        foreach (var ArrElem in Freq)
        {
            Console.WriteLine("Character " + ArrElem.Key + ": " + ArrElem.Count() + " times");
        }
        Console.ReadLine();
    }
}