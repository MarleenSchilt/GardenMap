using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenMap
{
    class PlantViewModel
    {
        private Plant _plant;

        public PlantViewModel(Plant plant)
        {
            _plant = plant;
        }

        public string Name
        {
            get { return _plant.Name; }
        }
        public string Bloeitijd
        {
            get { return _plant.Bloeitijd; }
        }
        public System.Drawing.Color Bloeikleur
        {
            get { return _plant.Bloeikleur; }
        }
        public string Snoeitijd
        {
            get { return _plant.Snoertijd; }
        }
        public string Ondergrond
        {
            get { return _plant.Ondergrond; }
        }
        public bool Wintergroen
        {
            get { return _plant.Wintergroen; }
        }
    }
}
