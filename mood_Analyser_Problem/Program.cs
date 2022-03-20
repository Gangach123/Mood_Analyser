using System;
namespace Mood_Analyser_Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Mood analyser program.");
            HappyOrSad happySad = new HappyOrSad();
            string Result = happySad.AnalysingMood();
            Console.WriteLine(Result);
        }
    }
}
