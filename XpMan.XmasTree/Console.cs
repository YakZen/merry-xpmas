using System.Text;

namespace XpMan.XmasTree
{
    public class Console
    {
        public static StringBuilder PresentsOutput = new StringBuilder();


        public static void WriteLine(string s)
        {
            PresentsOutput.AppendLine(s);
            System.Console.WriteLine(s);
        }
        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            PresentsOutput.AppendLine(string.Format(format, arg0, arg1, arg2));
            System.Console.WriteLine(string.Format(format, arg0, arg1, arg2));
        }

        public static void ReadLine()
        {
            System.Console.ReadLine();
        }
    }
}