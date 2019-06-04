using System;

namespace TryDotNet.CodingClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            var bits = args[1].Split("_");

            switch(bits[0])
            {
                case nameof(Workshop2):
                    Workshop2.RunSample(bits[1]);
                    break;
                case nameof(Workshop3):
                    Workshop3.RunSample(bits[1]);
                    break;
            }
        }
    }
}
