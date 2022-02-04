using System;
//This code goes into a infinite loop.
//Because the max value of byte is 255 which is smaller than 500.
namespace Exercise03_2 {
    class program
    {
        public static void Main(String[] args)
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                if (i == 255)
                {
                    Console.WriteLine("Warning: the value of i " +
                        "will out of the range of the assigned data type.");
                    break;//Added to break the loop.
                }
                else
                {
                    Console.WriteLine(i);
                    
                }
            }
        }
    }
}