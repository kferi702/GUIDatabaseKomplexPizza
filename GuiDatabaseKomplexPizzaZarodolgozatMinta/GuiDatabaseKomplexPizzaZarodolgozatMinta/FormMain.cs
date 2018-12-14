﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiDatabaseKomplexPizzaZarodolgozatMinta
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tabControlPizza.SelectTab(0);
            tabControlPizza.SelectedTab = tabPagePizza;
        }

        private void vevőToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlPizza.SelectedTab = tabPageVevo;
        }

        private void futárToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControlPizza.SelectedTab = tabPageFutar;
        }
    }
}