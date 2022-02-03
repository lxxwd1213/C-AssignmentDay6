using System;
namespace _02Convert {

    class program
    {
        public static void Main(String[] args)
        {

            int i = 0;
            Console.WriteLine("Please enter an integer:");
            i = Convert.ToInt32(Console.ReadLine());
            int c = i;
            int y = c * 100;
            double d = Convert.ToDouble(y * 365.24);
            long h = Convert.ToInt32(d * 24);
            long min = h * 60;
            long sec = min * 60;
            ulong msec = Convert.ToUInt64(sec * 1000);
            ulong usec = msec * 1000;
            ulong nsec = usec * 1000;

            Console.WriteLine(c + " centuries = " + y + " years = " + d + " days = "
                + h + " hours = " + min + " minutes = " + sec + " seconds = " +
                msec + " milliseconds" + usec + " microseconds" + nsec + " nanoseconds");

        }
    }


}

