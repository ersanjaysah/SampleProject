using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleVisualStudio
{
    internal class SampleClass
    {
        public void SampleMethod(int a)
        {
            Console.WriteLine("hellow sanjay"+ a );


        }
        public static void StaticMethod()
        {
           string userInput= Console.ReadLine();
            Console.WriteLine(userInput);
            int userInput1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userInput1);
        }
    }
}
