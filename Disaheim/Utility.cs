using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {

            
               if (amulet.Quality == Level.Low) //man laver en if statement for at få retuneret den værdi der passer til qualiteten
                {
                    return 12.5;
                }
                else if (amulet.Quality == Level.Medium)
                {
                    return 20.0;
                }
            else //returnerer high fordi det er den eneste som er tilbage
            {
                    return 27.5;
                }
            
        }
    }
}
