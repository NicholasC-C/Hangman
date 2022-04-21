using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        protected List<int> letter_placement_positions = new List<int>();
        protected List<bool> letters_guessed = new List<bool>();

        protected string word;
        protected int wrong_guesses;

        public Game(string word)
        {
            this.word = word;
            start();
        }

        public virtual void start()
        {
            wrong_guesses = 0;

            // Intialize letters guessed
            for (int i = 0; i < this.word.Length; i++)
                letters_guessed.Add(false);
        }

        public virtual void run()
        {
            while (wrong_guesses <= 6)
            {
                Visual_Hangman.display_hangman(wrong_guesses);
                display_letters();
                guess_letter();

                Console.Clear();
                if (check_if_won())
                {
                    Console.WriteLine("You won!");
                    break;
                }
                if (wrong_guesses >= 6)
                {
                    Console.WriteLine("You lost...");
                    break;
                }
            }
            Console.ReadKey();
        }

        protected void display_letters()
        {
            for (int i = 0; i < word.Length; i++)
            {
                int x_pos = (1 + i) * 2;
                letter_placement_positions.Add(x_pos);
                Console.SetCursorPosition(x_pos, 8);
                if (letters_guessed[i] == true)
                    Console.WriteLine(word[i].ToString());
                else
                    Console.WriteLine("_");
            }
        }
        protected void guess_letter()
        {
            // Make guess
            Console.WriteLine("Guess a letter: ");
            ConsoleKeyInfo input = Console.ReadKey(true);

            // Check if the letter is in the word
            bool got_atleast_one_right = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].ToString() == input.KeyChar.ToString().ToLower())
                {
                    got_atleast_one_right = true;
                    letters_guessed[i] = true;
                }
            }
            if (!got_atleast_one_right)
                wrong_guesses++;
        }
        protected bool check_if_won()
        {
            for (int i = 0; i < letters_guessed.Count; i++)
            {
                if (!letters_guessed[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
