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
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("|    ");
                    Console.WriteLine("|    ");
                    Console.WriteLine("|    ");
                    Console.WriteLine("===   ");
                    break;
                case 1:
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("|   O");
                    Console.WriteLine("|    ");
                    Console.WriteLine("|    ");
                    Console.WriteLine("===   ");
                    break;
                case 2:
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("|   O");
                    Console.WriteLine("|   |");
                    Console.WriteLine("|    ");
                    Console.WriteLine("===   ");
                    break;
                case 3:
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("|   O");
                    Console.WriteLine("|  /|");
                    Console.WriteLine("|    ");
                    Console.WriteLine("===   ");
                    break;
                case 4:
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("|   O");
                    Console.WriteLine("|  /|\\");
                    Console.WriteLine("|    ");
                    Console.WriteLine("===   ");
                    break;
                case 5:

                    Console.WriteLine("\n+---+");
                    Console.WriteLine("|   O");
                    Console.WriteLine("|  /|\\");
                    Console.WriteLine("|  /");
                    Console.WriteLine("===   ");
                    break;
                case 6:
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("|   O");
                    Console.WriteLine("|  /|\\");
                    Console.WriteLine("|  / \\");
                    Console.WriteLine("===   ");
                    break;
            }
        }
    }
}
