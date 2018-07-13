using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenMap
{
    public partial class PlantInfoPropertyGrid : Form
    {
        public PlantInfoPropertyGrid(Plant plant)
        {
            InitializeComponent();
            PlantViewModel vm = new PlantViewModel(plant);
            this.propertyGrid1.SelectedObject = vm;
        }
    }
}
