using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var createCommand = Console.ReadLine().Split(' ').ToList();
            var listyIterator = new ListyIterator<string>();

            if (createCommand.Count > 1)
            {
                for (int i = 1; i < createCommand.Count; i++)
                {
                    listyIterator.Add(createCommand[i]);
                }
            }


            var inputLine = Console.ReadLine();

            while (inputLine != "END")
            {
                switch (inputLine)
                {
                    case "Move":
                        if (listyIterator.Move() == true)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "HasNext":
                        if (listyIterator.HasNext() == true)
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                    case "PrintAll":
                        listyIterator.PrintAll();
                        break;
                }


                inputLine = Console.ReadLine();
            }
        }
    }
}
