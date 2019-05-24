using System;

namespace TryDotNet.CodingClinic
{
    class Program
    {
        static void Main(string region = null,
            string session = null,
            string package = null,
            string project = null,
            string[] args = null)
        {
            switch(region)
            {
                case nameof(Sample1):
                    Sample1();
                    break;
                case nameof(Sample2):
                    Sample2();
                    break;
                case nameof(Sample3):
                    Sample3();
                    break;
                case nameof(Sample4):
                    Sample4();
                    break;
                case nameof(Sample5):
                    Sample5();
                    break;
            }
        }

        static void Sample1()
        {
            #region Sample1
            Console.WriteLine("Hello World!");
            #endregion Sample1
        }

        static void Sample2()
        {
            #region Sample2
            Console.WriteLine("Hello World!");
            #endregion Sample2
        }

        static void Sample3()
        {
            #region Sample3
            var hello = "Hello";
            var name = "your name";
            Console.WriteLine(hello + name);
            #endregion Sample3
        }

        static void Sample4()
        {
            #region Sample4
            var hello = "Hello";
            var name = "your name";
            Console.WriteLine(hello + name);
            #endregion Sample4
        }

        static void Sample5()
        {
            #region Sample5
            Console.WriteLine("Hello World!");
            #endregion Sample5
        }
    }
}
