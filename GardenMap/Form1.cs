﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            PlantInfoPropertyGrid info = new PlantInfoPropertyGrid(new Plant());
            info.ShowDialog();
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
