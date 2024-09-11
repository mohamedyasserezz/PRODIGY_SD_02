using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODIGY_SD_02
{
    internal class GuessingGame
    {
        private int Attempts { get; set; }
        private readonly int _target;
        public GuessingGame(IRandomNumberStrategy strategy)
        {
            Attempts = 0;
            _target = strategy.GenerateNumber();
        }

        public void Build()
        {
            Console.WriteLine("Welcome To Gessing Game\nPlz Try To Guess The Number");

            bool IsCorrect = false;
            while (!IsCorrect)
            {
                int guess = GetUserGuess();
                IsCorrect = CheckGuess(guess);
            }
            Console.WriteLine($"You guessed the correct number in {Attempts} attempts.");
        }
        private int GetUserGuess()
        {
            int guess;
            while (true)
            {
                do
                {
                    Console.Write("Enter your guess: ");

                } while (!int.TryParse(Console.ReadLine(), out guess));
                return guess;
            }
        }
        private bool CheckGuess(int guess)
        {
            Attempts++;
            if (guess > _target)
            {
                if (guess - _target > 10)
                    Console.WriteLine("Too high! Try again.");
                else
                    Console.WriteLine("A little high! Try again.");
                return false;
            }
            else if (guess < _target)
            {
                if (_target - guess > 10)
                    Console.WriteLine("Too low! Try again.");
                else
                    Console.WriteLine("A little low! Try again.");
                return false;
            }
            else
            {
                Console.WriteLine($"Congratulations! You've guessed the correct number: {_target}");
                return true;
            }
        }

    }
}
