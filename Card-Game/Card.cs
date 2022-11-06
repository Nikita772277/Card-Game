using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Card
    {
        private string _name;
        public Card()
        {
            _name = _name;
        }
        public string CreateCard()
        {
            Random random = new Random();
            switch (random.Next(1, 36))
            {
                case 1:
                    return _name = "6 черва";
                    break;
                case 2:
                   return _name = "6 пика";
                    break;
                case 3:
                   return _name = "6 трефа";
                    break;
                case 4:
                  return  _name = "6 бубна";
                    break;
                case 5:
                   return _name = "7 черва";
                    break;
                case 6:
                   return _name = "7 пика";
                    break;
                case 7:
                   return _name = "7 трефа";
                    break;
                case 8:
                   return _name = "7 бубна";
                    break;
                case 9:
                   return _name = "8 черва";
                    break;
                case 10:
                   return _name = "8 пика";
                    break;
                case 11:
                  return  _name = "8 трефа";
                    break;
                case 12:
                  return _name = "8 бубна";
                    break;
                case 13:
                   return _name = "9 черва";
                    break;
                case 14:
                   return _name = "9 пика";
                    break;
                case 15:
                   return _name = "9 трефа";
                    break;
                case 16:
                   return _name = "9 бубна";
                    break;
                case 17:
                   return _name = "10 черва";
                    break;
                case 18:
                   return _name = "10 пика";
                    break;
                case 19:
                   return _name = "10 трефа";
                    break;
                case 20:
                  return  _name = "10 бубна";
                    break;
                case 21:
                   return _name = "валет черва";
                    break;
                case 22:
                   return _name = "валет пика";
                    break;
                case 23:
                   return _name = "валет трефа";
                    break;
                case 24:
                  return  _name = "валет бубна";
                    break;
                case 25:
                  return  _name = "дама черва";
                    break;
                case 26:
                   return _name = "дама пика";
                    break;
                case 27:
                   return _name = "дама трефа";
                    break;
                case 28:
                   return _name = "дама бубна";
                    break;
                case 29:
                  return  _name = "король черва";
                    break;
                case 30:
                   return _name = "король пика";
                    break;
                case 31:
                  return  _name = "король трефа";
                    break;
                case 32:
                   return _name = "король бубна";
                    break;
                case 33:
                   return _name = "туз черва";
                    break;
                case 34:
                   return _name = "туз пика";
                    break;
                case 35:
                   return _name = "туз трефа";
                    break;
                case 36:
                  return  _name = "туз бубна";
                    break;
            }
            return "0";
        }
        public void CreateDeck()
        {
            int j = 0;
            var a = new List<string>();
            for (int i = 1; i <= 36;)
            {
                string n =null;
                 n=CreateCard();
                if (false == a.Contains(n))
                {
                    a.Add(n);
                    i++;
                    Console.WriteLine(n);
                    j++;
                    Console.WriteLine(j);
                }
            }
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}
