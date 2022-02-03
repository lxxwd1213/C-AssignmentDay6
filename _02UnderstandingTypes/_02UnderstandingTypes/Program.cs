using System;
namespace _02UnderstandingTypes {

    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("The number of bytes in memory of sbyte is 1 byte." +
                "The max value sbyte can have is 127, the min value sbyte can have is -128.");
            Console.WriteLine("The number of bytes in memory of byte is 1 byte. " +
                "The max value byte can have is 255, the min value byte can have is 0.");
            Console.WriteLine("The number of bytes in memory of short is 2 bytes." +
                "The max value short can have is 32767, the min value short can have is -32768.");
            Console.WriteLine("The number of bytes in memory of ushort is 2 bytes." +
                "The max value ushort can have is 65535, the min value ushort can have is 0.");
            Console.WriteLine("The number of bytes in memory of int is 4 bytes." +
                "The max value int can have is 2147483647, the min value int can have is -2147483648.");
            Console.WriteLine("The number of bytes in memory of unint is 4 bytes." +
                "The max value unint can have is 4294967295, the min value unint can have is 0.");
            Console.WriteLine("The number of bytes in memory of long is 8 bytes." +
                "The max value long can have is 9223372036854775808, the min value long can have is -9223372036854775807.");
            Console.WriteLine("The number of bytes in memory of unlong is 8 bytes." +
                "The max value unlong can have is 18446744073709551615, the min value unlong can have is 0.");
            Console.WriteLine("The number of bytes in memory of float is 4 bytes." +
                "The max value float can have is 3.4*10^38, the min value float can have is -1.5*10^-45.");
            Console.WriteLine("The number of bytes in memory of double is 8 bytes." +
                "The max value double can have is 1.7*10^308, the min value double can have is -5*10^-324.");
            Console.WriteLine("The number of bytes in memory of decimal is 16 bytes." +
                "The max value decimal can have is 7.9*10^28, the min value decimal can have is -1*10^-28.");

        }
    }

}