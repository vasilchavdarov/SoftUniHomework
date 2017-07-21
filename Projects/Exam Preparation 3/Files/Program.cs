using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var fileByRoot = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var rootline = Console.ReadLine().Split('\\');
                var root = rootline[0];
                var fileWithSize = rootline[rootline.Length - 1].Split(';');

                var fileNameWithExtension = fileWithSize[0];
                var size = long.Parse(fileWithSize[1]);

                if (!fileByRoot.ContainsKey(root))
                {
                    fileByRoot.Add(root, new Dictionary<string, long>());
                }

                if (!fileByRoot[root].ContainsKey(fileNameWithExtension))
                {
                    fileByRoot[root].Add(fileNameWithExtension, size);
                }
                else
                {
                    fileByRoot[root][fileNameWithExtension] = size;
                }

            }

            var queryLine = Console.ReadLine().Split(' ');

            var queryExtansion = queryLine[0];
            var queryRoot = queryLine[2];

            if (fileByRoot.ContainsKey(queryRoot))
            {
                var fountFiles = fileByRoot[queryRoot];


                foreach (var file in fountFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (file.Key.EndsWith(queryExtansion))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
