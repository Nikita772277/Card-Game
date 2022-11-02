using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Card
    {
        private string _number;
        private string _suit;
        public void CreateCard()
        {
            Random random = new Random();
            switch (random.Next(6,14))
            {
                case 6:
                    _number = "6";
                    break;
                case 7:
                    _number = "7";
                    break;
                case 8:
                    _number = "8";
                    break;
                case 9:
                    _number = "9";
                    break;
                case 10:
                    _number = "10";
                    break;
                case 11:
                    _number = "Волет";
                    break;
                case 12:
                    _number = "Дама";
                    break;
                case 13:
                    _number = "Король";
                    break;
                case 14:
                    _number = "Туз";
                    break;
            }
            switch (random.Next(1,4))
            {
                case 1:
                    _suit = "Черва";
                    break;
                case 2:
                    _suit = "Трефа";
                    break;
                case 3:
                    _suit = "Пика";
                    break;
                case 4:
                    _suit = "Бубна";
                    break;
            }
        }
    }
}
