using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ProgramOne
    {
        private string _input { get; set; }
        public string Input { get { return _input; } }

        public static void Main()
        {
            Console.WriteLine("Simple Console App");
            Console.ReadKey();
        }

        public void InputSetter(string val)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter something: ");

            if (val != null)
            {
                _input = val;
            }

            Console.WriteLine($"This was your {Input}");
        }
    }
}
