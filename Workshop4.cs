using System;

namespace TryDotNet.CodingClinic
{
    public class Workshop4
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
                case nameof(Sample6):
                    Sample6();
                    break;
            }
        }

        static void Sample1()
        {
            #region Workshop4_Sample1
            var hello = "Hello";
            var name = "your name";
            Console.WriteLine(hello + name);
            #endregion Workshop4_Sample1
        }

        static void Sample2()
        {
            #region Workshop4_Sample2
            var numberOne = "7";
            var numberTwo = "3";
            Console.WriteLine(numberOne + numberTwo);
            #endregion Workshop4_Sample2
        }

        static void Sample3()
        {
            #region Workshop4_Sample3
            int someInt = 27;
            int anotherInt = 13;
            var combinedInt = someInt + anotherInt;
            Console.WriteLine(combinedInt);
            #endregion Workshop4_Sample3
        }

        static void Sample4()
        {
            #region Workshop4_Sample4
            var someText = "27";
            int myInt;
            int.TryParse(someText, out myInt);
            Console.WriteLine(myInt);
            #endregion Workshop4_Sample4
        }

        static void Sample5()
        {
            #region Workshop4_Sample5
            var someText = "Twenty-Seven";
            int myInt;
            int.TryParse(someText, out myInt);
            Console.WriteLine(myInt);
            #endregion Workshop4_Sample5
        }

        static void Sample6()
        {
            #region Workshop4_Sample6
            var numberString = "Put something here";
            int number;
            int.TryParse(numberString, out number);

            //write your if/else statement here
            #endregion Workshop4_Sample6
        }
    }
}