using System;

namespace TryDotNet.CodingClinic
{
    public class Workshop2
    {
        public static void RunSample(string region)
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
            #region Workshop2_Sample1
            Console.WriteLine("Hello World!");
            #endregion Workshop2_Sample1
        }

        static void Sample2()
        {
            #region Workshop2_Sample2
            Console.WriteLine("Hello World!");
            #endregion Workshop2_Sample2
        }

        static void Sample3()
        {
            #region Workshop2_Sample3
            var hello = "Hello";
            var name = "your name";
            Console.WriteLine(hello + name);
            #endregion Workshop2_Sample3
        }

        static void Sample4()
        {
            #region Workshop2_Sample4
            var hello = "Hello";
            var name = "your name";
            Console.WriteLine(hello + name);
            #endregion Workshop2_Sample4
        }

        static void Sample5()
        {
            #region Workshop2_Sample5
            Console.WriteLine("Hello World!");
            #endregion Workshop2_Sample5
        }
    }
}