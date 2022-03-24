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
            HappyOrSad happySad = new HappyOrSad("SAD");
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
        /*[TestMethod]
        public void GivenNull_RetunHappy()
        {
            HappyOrSad happySad = new HappyOrSad(null);
            string result = happySad.AnalysingMood();

            Assert.AreEqual("HAPPY", result);
        }*/
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
        [TestMethod]
        public void GivingClassNameRight_ReturnsObject()
        {
            try
            {
                var expected = new HappyOrSad("lines");
                MoodAnalserReflection factory = new MoodAnalserReflection("mood_Analyser_Problem.HappyOrSad", "HappyOrSad");
                var MyObj = MoodAnalserReflection.FactoryMethod(factory, "lines");
                expected.Equals(MyObj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("class name is wrong", ex.Message);
            }
        }


        [TestMethod]
        public void GivingClassNameWrong_RetunCustomException()
        {
            try
            {
                HappyOrSad happySad = new HappyOrSad("lines");
                MoodAnalserReflection factory = new MoodAnalserReflection("mood_Analyser_Problem.HappyOrS", "HappyOrSad");
                var MyObj = MoodAnalserReflection.FactoryMethod(factory, "lines");
            }
            catch (CustomException ex)
            { 
        
                Assert.AreEqual("class name is wrong", ex.Message);
            }
        }


        [TestMethod]
        public void GivingConstructorWrong_RetunCustomException()
        {
            try
            {
                HappyOrSad happySad = new HappyOrSad("lines");
                MoodAnalserReflection factory = new MoodAnalserReflection("mood_Analyser_Problem.HappyOrSad", "HappySa");
                var MyObj = MoodAnalserReflection.FactoryMethod(factory, "lines");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("constructor name is wrong", ex.Message);
            }
        }
        [TestMethod]
        public void GivingMessageRight_ReturnsObject()
        {
            try
            {
                HappyOrSad happySad = new HappyOrSad("I am happy");
                MoodAnalserReflection factory = new MoodAnalserReflection("mood_Analyser_Problem.HappyOrSad", "HappyOrSad");
                object MyObj = MoodAnalserReflection.InvokeMethod(factory, "I am happy");
                happySad.Equals(MyObj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class name is wrong", ex.Message);
            }
        }


        [TestMethod]
        public void GivingMessageWrong_RetunCustomException()
        {
            try
            {
                HappyOrSad happySad = new HappyOrSad("Mood of mine is good");
                MoodAnalserReflection factory = new MoodAnalserReflection("mood_Analyser_Problem.HappyOrSad", "HappyOrSad");
                var MyObj = MoodAnalserReflection.InvokeMethod(factory, "Mood of mine is good");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class name is wrong", ex.Message);
            }
        }
        [TestMethod]
        public void GivingFieldName_Wrong_RetunCustomException()
        {
            string Expected = "Wrong field name";
            try
            {
                var result = Reflector.SetField("I am Happy", "WrongField");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }

        [TestMethod]
        public void GiveingMessage_Wrong_RetunCustomException()
        {
            string Expected = "Message should not be null";
            try
            {
                var result = Reflector.SetField(null, "Message");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(Expected, ex.Message);
            }
        }
    }
}

