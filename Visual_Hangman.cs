using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    static class Visual_Hangman
    {
        static public void display_hangman(int wrong_guesses)
        {
            Console.SetCursorPosition(30, 1);
            switch (wrong_guesses)
            {
                case 0:
                    Console.WriteLine("\n ___________.._______");
                    Console.WriteLine("| .__________))______|");
                    Console.WriteLine("| | / /      ");
                    Console.WriteLine("| |/ /         ");
                    Console.WriteLine("| | /          ");
                    Console.WriteLine("| |/         ");
                    Console.WriteLine("| |          ");
                    Console.WriteLine("| |             ");
                    Console.WriteLine("| |         ");
                    Console.WriteLine("| |        ");
                    Console.WriteLine("| |                 ");
                    Console.WriteLine("| |                 ");
                    Console.WriteLine("| |                 ");
                    Console.WriteLine("| |            ");
                    Console.WriteLine("| |             ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("''''''''''|_       |''' | ");
                    break;
                case 1:
                    Console.WriteLine("\n ___________.._______");
                    Console.WriteLine("| .__________))______|");
                    Console.WriteLine("| | / /      ||");
                    Console.WriteLine("| |/ /       ||");
                    Console.WriteLine("| | /        ||.-''.");
                    Console.WriteLine("| |/         |/  _  |");
                    Console.WriteLine("| |          ||  `/,|");
                    Console.WriteLine("| |          (`_. '");
                    Console.WriteLine("| |         .-`--'.");
                    Console.WriteLine("| |        ");
                    Console.WriteLine("| |                 ");
                    Console.WriteLine("| |                 ");
                    Console.WriteLine("| |                 ");
                    Console.WriteLine("| |            ");
                    Console.WriteLine("| |             ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("''''''''''|_       |''' | ");
                    break;
                case 2:
                    Console.WriteLine("\n ___________.._______");
                    Console.WriteLine("| .__________))______|");
                    Console.WriteLine("| | / /      ||");
                    Console.WriteLine("| |/ /       ||");
                    Console.WriteLine("| | /        ||.-''.");
                    Console.WriteLine("| |/         |/  _  |");
                    Console.WriteLine("| |          ||  `/,|");
                    Console.WriteLine("| |          (`_. '");
                    Console.WriteLine("| |         .-`--'.");
                    Console.WriteLine("| |        |Y . . Y|");
                    Console.WriteLine("| |          |   |   ");
                    Console.WriteLine("| |          | . |   ");
                    Console.WriteLine("| |          |   |    ");
                    Console.WriteLine("| |            ");
                    Console.WriteLine("| |             ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("''''''''''|_       |''' | ");
                    break;
                case 3:
                    Console.WriteLine("\n ___________.._______");
                    Console.WriteLine("| .__________))______|");
                    Console.WriteLine("| | / /      ||");
                    Console.WriteLine("| |/ /       ||");
                    Console.WriteLine("| | /        ||.-''.");
                    Console.WriteLine("| |/         |/  _  |");
                    Console.WriteLine("| |          ||  `/,|");
                    Console.WriteLine("| |          (`_. '");
                    Console.WriteLine("| |         .-`--'.");
                    Console.WriteLine("| |        /Y . . Y|");
                    Console.WriteLine("| |       // |   |   ");
                    Console.WriteLine("| |      //  | . |   ");
                    Console.WriteLine("| |     ')   |   |    ");
                    Console.WriteLine("| |            ");
                    Console.WriteLine("| |             ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("''''''''''|_       |''' | ");
                    break;
                case 4:
                    Console.WriteLine("\n ___________.._______");
                    Console.WriteLine("| .__________))______|");
                    Console.WriteLine("| | / /      ||");
                    Console.WriteLine("| |/ /       ||");
                    Console.WriteLine("| | /        ||.-''.");
                    Console.WriteLine("| |/         |/  _  |");
                    Console.WriteLine("| |          ||  `/,|");
                    Console.WriteLine("| |          (`_. '");
                    Console.WriteLine("| |         .-`--'.");
                    Console.WriteLine("| |        /Y . . Y|");
                    Console.WriteLine("| |       // |   | ||");
                    Console.WriteLine("| |      //  | . |  ||");
                    Console.WriteLine("| |     ')   |   |   (`");
                    Console.WriteLine("| |            ");
                    Console.WriteLine("| |             ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("| |              ");
                    Console.WriteLine("''''''''''|_       |''' | ");
                    break;
                case 5:
                    Console.WriteLine("\n ___________.._______");
                    Console.WriteLine("| .__________))______|");
                    Console.WriteLine("| | / /      ||");
                    Console.WriteLine("| |/ /       ||");
                    Console.WriteLine("| | /        ||.-''.");
                    Console.WriteLine("| |/         |/  _  |");
                    Console.WriteLine("| |          ||  `/,|");
                    Console.WriteLine("| |          (`_. '");
                    Console.WriteLine("| |         .-`--'.");
                    Console.WriteLine("| |        /Y . . Y|");
                    Console.WriteLine("| |       // |   | ||");
                    Console.WriteLine("| |      //  | . |  ||");
                    Console.WriteLine("| |     ')   |   |   (`");
                    Console.WriteLine("| |          ||'  ");
                    Console.WriteLine("| |          ||   ");
                    Console.WriteLine("| |          ||    ");
                    Console.WriteLine("| |         / |   ");
                    Console.WriteLine("''''''''''|_`-'     |''' | ");
                    break;
                case 6:
                    Console.WriteLine("\n ___________.._______");
                    Console.WriteLine("| .__________))______|");
                    Console.WriteLine("| | / /      ||");
                    Console.WriteLine("| |/ /       ||");
                    Console.WriteLine("| | /        ||.-''.");
                    Console.WriteLine("| |/         |/  _  |");
                    Console.WriteLine("| |          ||  `/,|");
                    Console.WriteLine("| |          (`_. '");
                    Console.WriteLine("| |         .-`--'.");
                    Console.WriteLine("| |        /Y . . Y|");
                    Console.WriteLine("| |       // |   | ||");
                    Console.WriteLine("| |      //  | . |  ||");
                    Console.WriteLine("| |     ')   |   |   (`");
                    Console.WriteLine("| |          ||'||");
                    Console.WriteLine("| |          || ||");
                    Console.WriteLine("| |          || || ");
                    Console.WriteLine("| |         / | | |");
                    Console.WriteLine("''''''''''|_`-' `-' |''' | ");
                    break;
            }
        }
    }
}
