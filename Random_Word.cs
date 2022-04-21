using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    static class Random_Word
    {
        static public string get_random_word()
        {
            List<string> list_of_words = new List<string>();
            list_of_words.Add("arise");
            list_of_words.Add("assignment");
            list_of_words.Add("timber");
            list_of_words.Add("compromise");
            list_of_words.Add("root");
            list_of_words.Add("disagreement");
            list_of_words.Add("copper");
            list_of_words.Add("winter");

            Random randNum = new Random();
            int random_position = randNum.Next(list_of_words.Count);
            
            return list_of_words[random_position];
            }
    }
}
