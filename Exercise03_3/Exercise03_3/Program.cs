using System;

namespace Exercise03_3 {

    class program {

        public static void Main(String[] args) {

            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please enter your guess number:");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber == correctNumber) {
                Console.WriteLine("Correct!");
            } else if (guessedNumber < correctNumber) {
                Console.WriteLine("Low!");
            } else if (guessedNumber > correctNumber)
            {
                Console.WriteLine("High!");
            } else if (guessedNumber > 2147483647) {
                Console.WriteLine("Invaid Number.");
            } 
        }
    }
}

