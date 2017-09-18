namespace _01.Stream_Progress
{
    public class Program
    {
        public static void Main()
        {
            var music = new Music("dawd", "dawda", 5, 100);

            var streamProgress = new StreamProgressInfo(music);

            System.Console.WriteLine(streamProgress.CalculateCurrentPercent());
        }
    }
}
