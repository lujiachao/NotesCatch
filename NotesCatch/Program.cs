using System;
using System.Xml;

namespace NotesCatch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            XmlNoteTest();
        }

        /// <summary>
        /// xml注释获取测试
        /// </summary>
        public static void XmlNoteTest()
        {
            XmlElement documentation = CatchXmlReflection.XMLFromMember(typeof(SomeExampleClass).GetProperty("ExampleProperty"));
            Console.WriteLine(documentation["summary"].InnerText.Trim());
            Console.ReadKey();
        }
    }
}
