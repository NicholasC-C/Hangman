using Hangman;
while (true)
{   
    Console.WriteLine("Choose mode to play");
    Console.WriteLine("1. Singeplayer");
    Console.WriteLine("2. Multiplayer");
    ConsoleKeyInfo input = Console.ReadKey(true);
    Console.Clear();
    switch (input.KeyChar)
    {
        case '1':
            Game singleplayer_game = new Game(Random_Word.get_random_word());
            singleplayer_game.run();
            break;
        case '2':
            Game multiplayer_game = new Multiplayer_Game(Random_Word.get_random_word());
            multiplayer_game.run();
            break;
        default:
            break;
    }
    Console.Clear();
}
