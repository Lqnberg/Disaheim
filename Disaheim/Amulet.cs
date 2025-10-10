using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        //public string ItemId; // Dette er arvet fra Merchandise // flyttet til overclass Merchandise
        public string Design;
        public Level Quality;



        public Amulet(string itemId) : this (itemId, Level.Medium, "")
        {
        }

        public Amulet(string itemId, Level quality) : this (itemId, quality, "")  //dette er en constructor
        {
        }

        public Amulet(string itemId, Level quality, string design) //: base(itemId)
        {
            ItemId = itemId;
            Design = design;
            Quality = quality;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }



    }
}

