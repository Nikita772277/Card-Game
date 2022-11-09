using Card_Game;

Deck deck = new Deck();
Players players=new Players();
void GetMenu()
{
    Console.WriteLine();
    Console.WriteLine($"1) Начать игру");
    Console.WriteLine();
}
void Menu()
{
    while (true)
    {
        GetMenu();
        string enter = Console.ReadLine();
        bool enterr = int.TryParse(enter, out int parse);
        if (parse == 1)
        {
            players.NumberOfPlayers();
            deck.CreateDeck();
            deck.DistributionOfCards();
        }
        else { Console.WriteLine($"Выберите пункт из списка"); }
    }
}
Menu();

//deck.GetDeck();
