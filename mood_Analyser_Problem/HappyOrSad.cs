using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mood_Analyser_Program
{
    public class HappyOrSad
    {
        public HappyOrSad()
        {
        }
        public HappyOrSad(string message)
        {
            this.Message = message;
        }

        public string Message { get; }

        public string AnalysingMood()
        {
            try
            {
                if (this.Message.ToUpper().Contains("HAPPY"))
                {
                    return "HAPPY";
                }
                else if (this.Message.ToUpper().Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}

