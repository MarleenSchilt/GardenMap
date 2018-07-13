using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenMap
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Plant
    {
        public string Name { get; set; }
        public string Bloeitijd { get; set; }
        public System.Drawing.Color Bloeikleur { get; set; }
        public string Snoertijd { get; set; }
        public string Ondergrond { get; set; }
        public bool Wintergroen { get; set; }
        public string Winterhard { get; set; }

        public Plant(string name = "probeersel")
        {
            Name = name;
            Bloeikleur = System.Drawing.Color.Purple;
        }
    }
}
