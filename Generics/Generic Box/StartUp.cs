using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main(string[] args)
    {
        var numberOfLine = int.Parse(Console.ReadLine());
        var listOfBoxes = new List<Box<double>>();

        for (int i = 0; i < numberOfLine; i++)
        {
			var box = new Box<double>(double.Parse(Console.ReadLine()));

            listOfBoxes.Add(box);
        }

        var element = double.Parse(Console.ReadLine());
        var result = GetGreater(listOfBoxes, element);

        Console.WriteLine(result);

    }

    private static int GetGreater<T>(List<Box<T>> listOfBoxes, T elemet)
        where T : IComparable<T>
    {
        return listOfBoxes.Count(b => b.Value.CompareTo(elemet) > 0);
    }
}
