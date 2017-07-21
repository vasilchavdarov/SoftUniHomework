using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box
{
    public class Program
    {
        static void Main(string[] args)
        {

            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            try
            {
                var l = double.Parse(Console.ReadLine());
                var w = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());

                var box = new Box(l, w, h);

                Console.WriteLine($"Surface Area - {box.GetSurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.GetVolume():f2}");


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
        }
    }
}
