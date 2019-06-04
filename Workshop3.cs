using System;

namespace TryDotNet.CodingClinic
{
    public class Workshop3
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
            }
        }

        static void Sample1()
        {
            #region Workshop3_Sample1
            var myColourVariable = "blue";
            Console.WriteLine(myColourVariable == "red");
            #endregion Workshop3_Sample1
        }

        static void Sample2()
        {
            #region Workshop3_Sample2
            var myColourVariable = "blue";
            var myOtherColourVariable = "red";
            Console.WriteLine(myColourVariable == myOtherColourVariable);
            #endregion Workshop3_Sample2
        }

        static void Sample3()
        {
            #region Workshop3_Sample3
            var colour = "add a color here";

            if(colour == "green")
            {
                Console.WriteLine("Grass is green");
            }
            else
            {
                Console.WriteLine("The sky is blue");
            }
            #endregion Workshop3_Sample3
        }

        static void Sample4()
        {
            #region Workshop3_Sample4
            var colour = "add a color here";

            if(colour == "green")
            {
                Console.WriteLine("Grass is green");
            }
            else if(colour == "blue")
            {
                Console.WriteLine("The sky is blue");
            }
            else
            {
                Console.WriteLine("You didn't answer my question!");
            }
            #endregion Workshop3_Sample4
        }
    }
}