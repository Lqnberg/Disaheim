using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet
    {
        public string ItemId;
        public string Design;
        public Level Quality;



        public Amulet(string itemId) :
        this (itemId, Level.Medium, "")
        {
        }

        public Amulet(string itemId, Level quality) : //dette er en constructor
        this (itemId, quality, "")
        {
        }

        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }

        public override string ToString()
        {
            return $"itenId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }



    }
}




/*public Account (string inName, string inAddress, 
decimal inBalance)  
{ 
name = inName; 
address = inAddress; 
balance = inBalance; 
} 
public Account ( string inName, string inAddress ) : 
this (inName, inAddress, 0 ) 
{ 
} 
public Account ( string inName ) :  
this (inName, "Not Supplied", 0 )  
{ 
}
*/
