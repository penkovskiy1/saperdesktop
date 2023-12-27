using Miner.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            MapController.Init(this);
            bool temp = false;
            while (temp)
            {
                if (MapController.Win == MapController.ner)
                {
                    Menu form2 = new Menu();
                    form2.Show();
                    this.Hide();
                    temp = true;
                }
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu form2 = new Menu();
            form2.Show();
            this.Hide();
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
