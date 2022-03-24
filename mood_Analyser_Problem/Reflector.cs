using Mood_Analyser_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mood_Analyser_Problem
{
    public class Reflector
    {
        public static object InvokeMethod(string className, string constructor, string message)
        {

            //Type AnaylseType = typeof(HappySad);
            Assembly executing = Assembly.GetExecutingAssembly();
            Type AnaylseType = executing.GetType(className);
            if ("HappySad" == constructor)
            {

                if (AnaylseType.Name.Equals(className) || AnaylseType.FullName.Equals(className))
                {
                    try
                    {
                        /* Assembly executing = Assembly.GetExecutingAssembly();
                         Type AnaylseType = executing.GetType(className);*/
                        ConstructorInfo ctor = AnaylseType.GetConstructor(new[] { typeof(string) });
                        object MyObj = ctor.Invoke(new object[] { message });
                        return MyObj;
                    }
                    catch
                    {
                        throw new CustomException(CustomException.ExceptionType.WRONG_MESSAGE, "message should be proper");
                    }
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, "Class name is wrong");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor name is wrong");
            }
        }

        public static string SetField(string Data, string FieldName)
        {
            try
            {
                HappyOrSad obj = (HappyOrSad)InvokeMethod("mood_Analyser_Problem.HappyOrSad", "HappyOrSad", Data);
                Type type = typeof(HappyOrSad);
                FieldInfo fieldInfo = type.GetField(FieldName);
                if (fieldInfo != null)
                {
                    if (Data == null)
                    {
                        throw new CustomException(CustomException.ExceptionType.NULL_MESSAGE, "Message should not be null");
                    }

                    fieldInfo.SetValue(obj, Data);
                    return obj.Message;
                }
                throw new CustomException(CustomException.ExceptionType.WRONG_FIELD, "Wrong field name");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
