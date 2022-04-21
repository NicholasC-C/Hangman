using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Multiplayer_Game : Game
    {
        string player1_name;
        string player2_name;
        public Multiplayer_Game(string word) : base(word)
        {
        }

        public override void start()
        {
            wrong_guesses = 0;
        }

        public override void run()
        {
            Console.WriteLine("Player 1: type name");
            player1_name = Console.ReadLine();
            Console.WriteLine("Player 2: type name");
            player2_name = Console.ReadLine();

            Console.WriteLine($"{player1_name}, please enter a word you want {player2_name} to guess");
            word = Console.ReadLine();
            Console.Clear();

            // Intialize letters guessed
            for (int i = 0; i < this.word.Length; i++)
                letters_guessed.Add(false);

            while (wrong_guesses <= 6)
            {
                Visual_Hangman.display_hangman(wrong_guesses);
                display_letters();
                guess_letter();

                Console.Clear();
                if (check_if_won())
                {
                    Console.WriteLine($"{player2_name} won!");
                    break;
                }
                if (wrong_guesses >= 6)
                {
                    Console.WriteLine($"{player1_name} won!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
