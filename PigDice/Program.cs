using System;

namespace PigDice {
    class Program {
        //adding methods
        static int RollDie() {
            var rnd = new Random();
            return rnd.Next(1, 7);

        }
        static int PlayPigDice() {
            var score = 0;
            var roll = RollDie();
            while (roll != 1) {
                score += roll;
                roll = RollDie();
            }
            return score;
        }
        //main method
        static void Main(string[] args) {
            var highScore = 250;
            long counter = 0;
            var score = PlayPigDice();
            while (score < highScore) {
                if (score <= highScore) {
                    score = PlayPigDice();
                    counter++;

                }



            }


            Console.WriteLine($"High score is{score} in {counter} games");
        }
    }
}

