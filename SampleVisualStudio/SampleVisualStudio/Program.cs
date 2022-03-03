using System;

namespace SampleVisualStudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SampleClass.StaticMethod();
            SampleClass isc = new SampleClass();
            isc.SampleMethod(10);
        }
    }
}
