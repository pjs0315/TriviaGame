using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            //this will be the main menu where the user will navigate to the game that they want to play
            InitializeComponent();
            this.BackColor = Color.FromArgb(0,160,148);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            MemoryTrivia memory = new MemoryTrivia();
            this.Hide();
            memory.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();//seems to solve issue of process still running
        }

        private void btnTicTac_Click(object sender, EventArgs e)
        {
            TicTac ticTacToe = new TicTac();
            this.Hide();
            ticTacToe.Show();
        }
    }
}
