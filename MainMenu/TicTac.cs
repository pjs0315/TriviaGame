using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class TicTac : Form
    {

        int num = 1;

        public TicTac()
        {
            InitializeComponent();
        }

        private void checkWinner()
        {
            if (label1.Text == "X" && label5.Text == "X" && label7.Text == "X") //diag
            { label10.Text += " Player 1!"; }
            else if (label3.Text == "X" && label5.Text == "X" && label9.Text == "X")//diag
            { label10.Text += " Player 1!"; }
            else if (label1.Text == "X" && label4.Text == "X" && label9.Text == "X")//vert
            { label10.Text += " Player 1!"; }
            else if (label2.Text == "X" && label5.Text == "X" && label8.Text == "X")//vert
            { label10.Text += " Player 1!"; }
            else if (label3.Text == "X" && label6.Text == "X" && label7.Text == "X")//vert
            { label10.Text += " Player 1!"; }
            else if(label1.Text == "X" && label2.Text == "X" && label3.Text == "X") //horizontal
            { label10.Text += " Player 1!"; }
            else if(label4.Text == "X" && label5.Text == "X" && label6.Text == "X")//horizontal
            { label10.Text += " Player 1!"; }
            else if (label9.Text == "X" && label8.Text == "X" && label7.Text == "X")//horizontal
            { label10.Text += " Player 1!"; }//======================================================
            else if (label1.Text == "O" && label5.Text == "O" && label7.Text == "O") //diag
            { label10.Text += " Player 2!"; }
            else if (label3.Text == "O" && label5.Text == "O" && label9.Text == "O")//diag
            { label10.Text += " Player 2!"; }
            else if (label1.Text == "O" && label4.Text == "O" && label9.Text == "O")//vert
            { label10.Text += " Player 2!"; }
            else if (label2.Text == "O" && label5.Text == "O" && label8.Text == "O")//vert
            { label10.Text += " Player 2!"; }
            else if (label3.Text == "O" && label6.Text == "O" && label7.Text == "O")//vert
            { label10.Text += " Player 2!"; }
            else if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O") //horizontal
            { label10.Text += " Player 2!"; }
            else if (label4.Text == "O" && label5.Text == "O" && label6.Text == "O")//horizontal
            { label10.Text += " Player 2!"; }
            else if (label9.Text == "O" && label8.Text == "O" && label7.Text == "O")//horizontal
            { label10.Text += " Player 2!"; }
            else
            { label10.Text = "Draw"; }
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label myLabel = (Label)sender;
            
            int determinePlayer = (num % 2);
            
            if ((myLabel.Text == "") && (determinePlayer == 1))//odd
            { myLabel.Text = "X"; }
            if ((myLabel.Text == "") && (determinePlayer == 0))//even
            { myLabel.Text = "O"; }

            if (num < 11)
            { ++num; }

            if (num == 10)
            { checkWinner(); }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}
