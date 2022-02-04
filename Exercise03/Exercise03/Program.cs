using System;
namespace Exercise03 {

    class program {

        public static void Main(String[] args) {

            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzzis");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzziss");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

