using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnlyserFactory
    {
        public static object CreateMoodAnalyser(string ClassName, string ConstructorName)
        {
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(ClassName);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string ClassName, string ConstructorName, string message)
        {
            Type type = typeof(MoodAnalyse);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo constructorinfo = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructorinfo.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_CLASS, "Class not found");
                    throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new MoodCustomException(MoodCustomException.ExpType.NO_SUCH_CLASS, "Class not found");

            }
        }
    }
}

