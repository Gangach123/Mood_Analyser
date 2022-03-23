using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using mood_Analyser_Problem;

namespace Mood_Analyser_Program
{
    public class HappyOrSad
    {
        string Message;
        public HappyOrSad()
        {
        }
        public HappyOrSad(string message)
        {
            this.Message = message;
        }

        public string AnalysingMood()
        {
            try
            {
                if (this.Message.Contains("SAD"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
            
        }
    }
}

