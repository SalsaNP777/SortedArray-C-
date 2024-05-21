using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] n = {12, 9, 13, 6, 10, 4, 7, 2};
        var filteredArray = n.Where(x => x % 3 != 0).ToArray();

        Array.Sort(filteredArray);

        Console.Write("n = [ ");
        foreach (var item in filteredArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("]");
    }
}
