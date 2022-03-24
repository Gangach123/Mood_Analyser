using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace mood_Analyser_Problem
{
    public class MoodAnalserReflection
    {
        public string ClassName;
        public string Constructor;
        public MoodAnalserReflection(string className, string constructor)
        {
            this.ClassName = className;
            this.Constructor = constructor;
        }


        public static object FactoryMethod(MoodAnalserReflection factory, string message)
        {
            if ("HappyOrSad" == factory.Constructor)
            {
                try
                {
                    /*Assembly executing = Assembly.GetExecutingAssembly();
                    Type AnaylseType = executing.GetType(factory.ClassName);
                    var MyObj = Activator.CreateInstance(AnaylseType);
                    return MyObj;*/

                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type AnaylseType = executing.GetType(factory.ClassName);
                    ConstructorInfo ctor = AnaylseType.GetConstructor(new[] { typeof(string) });
                    object MyObj = ctor.Invoke(new object[] { message });
                    return MyObj;
                }
                catch
                {
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "class name is wrong");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "constructor name is wrong");
            }
        }
        public static object InvokeMethod(MoodAnalserReflection factory, string message)
        {
            try
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type AnaylseType = executing.GetType(factory.ClassName);
                ConstructorInfo ctor = AnaylseType.GetConstructor(new[] { typeof(string) });
                object MyObj = ctor.Invoke(new object[] { message });
                return MyObj;
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "class name is wrong");
            }
        }
    }
}
