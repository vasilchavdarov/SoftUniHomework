using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StartUp
{
    public static void Main()
    {
        //var dict = new Dictionary<string, Harvester>();
        //dict.Add("1", new SonicHarvester("1", 22, 33, 2));
        //dict.Add("2", new SonicHarvester("2", 12, 23, 5));

        //if (dict.ContainsKey("1"))
        //{
        //    foreach (var item in dict)
        //    {
        //        if (item.Key == "1")
        //        {
        //            var name = item.Value.GetType().Name;
        //            var index = name.IndexOf("Harvester");
        //            name = name.Insert(index, " ");

        //            Console.WriteLine(name + " " + item.Key);

        //            Console.WriteLine(item.Value.OreOutput);
        //        }
                

        //    }
        //}

        var engine = new Engine();
        engine.Run();
    }
}
