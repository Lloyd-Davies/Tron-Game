﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonTwoPlayer_Click(object sender, EventArgs e)
        {
            Application.Run(new GameWindow());
        }

        /*
        private void buttonMultiplayer_Click(object sender, EventArgs e)
        {
            Application.Run(new GameWindow());
        }
        */
    }
}
