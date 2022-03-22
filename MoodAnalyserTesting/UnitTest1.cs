using Microsoft.VisualStudio.TestTools.UnitTesting;
using mood_Analyser_Problem;
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
        [TestMethod]
        public void GivenNull_RetunHappy()
        {
            HappyOrSad happySad = new HappyOrSad(null);
            string result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void GivenNull_RetunCustomException()
        {
            try
            {
                HappyOrSad happySad = new HappyOrSad();
                string result = happySad.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("message should not be null", ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmpty_RetunCustomException()
        {
            try
            {
                HappyOrSad happySad = new HappyOrSad("");
                string result = happySad.AnalysingMood();
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("message should not be empty", ex.Message);
            }
        }
    }
}

