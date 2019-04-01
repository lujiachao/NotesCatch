using System;
using System.Collections.Generic;
using System.Text;

namespace NotesCatch
{
    public class SomeExampleClass
    {
        /// <summary>
        /// The contructor for the class
        /// </summary>
        public SomeExampleClass()
        {

        }

        /// <summary>
        /// Calculates the square of an integer
        /// </summary>
        /// <seealso cref="AnotherMethod"/>
        /// <param name="param">The number to generate the square of</param>
        /// <returns>The square of the parameter</returns>
        static public int Square(int param)
        {
            return param * param;
        }

        /// <summary>
        /// A function that does very little
        /// </summary>
        /// <returns>A string containing "Hello World"</returns>
        public string SimpleFunction()
        {
            return "HelloWorld";
        }

        /// <summary>
        /// A method that joins two strings
        /// </summary>
        /// <param name="input0">The first string</param>
        /// <param name="input1">The second string</param>
        /// <returns>The strings combined</returns>
        static public string AnotherMethod(string input0, string input1)
        {
            return (input0 + input1).ToLower();
        }

        /// <summary>
        /// An example of a property
        /// </summary>
        public int ExampleProperty
        {
            get { return somePrivateVar; }
            set { somePrivateVar = value; }
        }

        private int somePrivateVar;

        /// <summary>
        /// An example public field
        /// </summary>
        public int anExampleField = 99;
    }
}
