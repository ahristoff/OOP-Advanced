using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            //1
            IStreamable music = new Music("Lili", "vetrove", 10, 3);
            StreamProgressInfo abc = new StreamProgressInfo(music);

            Console.WriteLine(abc.CalculateCurrentPercent());

            //2
            //IStreamable music = new Music("Lili", "vetrove", 10, 3);
            //StreamProgressInfo abc = new StreamProgressInfo();

            //Console.WriteLine(abc.CalculateCurrentPercent(music));
        }
    }
}
