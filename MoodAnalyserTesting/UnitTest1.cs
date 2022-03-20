using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyser_Program;

namespace MoodAnalyserTesting
{
    [TestClass]
    public class MoodTesting
    {

        [TestMethod]
        public void GivenSad_ReturnSad()
        {
            HappyOrSad happySad = new HappyOrSad("I am in sad mood");
            string Result = happySad.AnalysingMood();

            Assert.AreEqual("SAD", Result);
        }

        [TestMethod]
        public void GivenHappy_ReturnHappy()
        {
            HappyOrSad happySad = new HappyOrSad("I am in happy mood");
            string Result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", Result);
        }
    }
}

