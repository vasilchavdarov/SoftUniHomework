using System;
class Sunglasses
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        string lens = new string('/', 2 * height - 2);
        string bridge = new string('|', height);
        string emptySpace = new string(' ', height);
        string lensAndFrame = string.Format("{0}{1}{0}", '*', lens);
        string frame = new string('*', 2 * height);

        for (int i = 0; i < height; i++)
        {
            if (i == 0 || i == height - 1)  //Print first and last row of the frame
            {
                Console.WriteLine("{0}{1}{0}", frame, emptySpace);
            }
            else if (i == height / 2)   //Print midlle frame row + bridge
            {
                Console.WriteLine("{0}{1}{0}", lensAndFrame, bridge);
            }
            else  //Print all other rows of the frame
            {
                Console.WriteLine("{0}{1}{0}", lensAndFrame, emptySpace);
            }
        }
    }
}