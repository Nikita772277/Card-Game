using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Players
    {
        private int _numberofplayers=2;
        private int _card=18;
        public void NumberOfPlayers()
        {
            Console.WriteLine("Введите количество игроков");
            string number = Console.ReadLine();
            bool numbe = int.TryParse(number, out var num);
            if (numbe == true)
            {
                if (num < 2)
                {
                    Console.WriteLine($"Слишком мало игроков для начала игры");
                }
                else if (num > 36)
                {
                    Console.WriteLine($"Слишком много игроков для начала игры");
                }
                else
                {
                    _numberofplayers = num;
                    int card = 36 / num;
                    _card = card;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Вы ввели не число");
            }

        }
    }
}
