using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic
{
    class Program
    {
        static void Main(string[] args)
        {
            var countload = int.Parse(Console.ReadLine());
            var microbustones = 0.0;
            var trucktones = 0.0;
            var traintones = 0.0;

            for (int i = 0; i < countload; i++)
            {
                var tones = double.Parse(Console.ReadLine());
                if (tones <= 3)
                {
                    microbustones += tones;
                }
                else if (tones >= 4 && tones <= 11)
                {
                    trucktones += tones;
                }
                else
                {
                    traintones += tones;
                }

            }
            var totaltones = microbustones + trucktones + traintones;
            var priceforton = (microbustones * 200 + trucktones * 175 + traintones * 120) / totaltones;

            var microbusrate = microbustones / totaltones * 100;
            var truckrate = trucktones / totaltones * 100;
            var trainrate = traintones / totaltones * 100;

            Console.WriteLine("{0:F2}",priceforton);
            Console.WriteLine("{0:F2}%",microbusrate);
            Console.WriteLine("{0:F2}%",truckrate);
            Console.WriteLine("{0:F2}%",trainrate);

        }
    }
}
