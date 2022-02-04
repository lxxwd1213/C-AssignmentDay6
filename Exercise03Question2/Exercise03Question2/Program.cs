using System;

namespace Exercise03Question2 {
    class program {
        public static void Main(String[] args)
        {

            Console.WriteLine("Pyramid.");

            for (int i = 1; i < 5; i++)
            {

                for (int j = 3; j >= i; j--)
                {
                    Console.Write(" ");
                }
                int k = 0;
                while (k != 2 * i - 1)
                { 
                    Console.Write("*");
                    k++;
                }
                Console.WriteLine();//Enter
            }

        }

    }
}