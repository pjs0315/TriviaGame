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
        bool foundWinner = false;

        public TicTac()
        {
            InitializeComponent();
        }

        #region "Disable Lables When Winner Found"
        private void endGame()
        {
            foreach (Control lbl in this.Controls)
            {
                if ((lbl is Label) && (lbl.Name != "label10"))              
                { lbl.Enabled = false; }
            }
        }
        #endregion

        #region "Check Winner Function"
        private void checkWinner()
        {
            if (label1.Text == "X" && label5.Text == "X" && label7.Text == "X") //diag
            { label10.Text += " Winner Player 1!"; foundWinner = true; }
            else if (label3.Text == "X" && label5.Text == "X" && label9.Text == "X")//diag
            { label10.Text += " Winner Player 1!"; foundWinner = true; }
            else if (label1.Text == "X" && label4.Text == "X" && label9.Text == "X")//vert
            { label10.Text += " Winner Player 1!"; foundWinner = true; }
            else if (label2.Text == "X" && label5.Text == "X" && label8.Text == "X")//vert
            { label10.Text += " Winner Player 1!"; foundWinner = true; }
            else if (label3.Text == "X" && label6.Text == "X" && label7.Text == "X")//vert
            { label10.Text += " Winner Player 1!"; foundWinner = true; }
            else if(label1.Text == "X" && label2.Text == "X" && label3.Text == "X") //horizontal
            { label10.Text += " Winner Player 1!"; foundWinner = true; }
            else if(label4.Text == "X" && label5.Text == "X" && label6.Text == "X")//horizontal
            { label10.Text += " Winner Player 1!"; foundWinner = true; }
            else if (label9.Text == "X" && label8.Text == "X" && label7.Text == "X")//horizontal
            { label10.Text += " Winner Player 1!"; foundWinner = true; }//======================================================
            else if (label1.Text == "O" && label5.Text == "O" && label7.Text == "O") //diag
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else if (label3.Text == "O" && label5.Text == "O" && label9.Text == "O")//diag
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else if (label1.Text == "O" && label4.Text == "O" && label9.Text == "O")//vert
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else if (label2.Text == "O" && label5.Text == "O" && label8.Text == "O")//vert
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else if (label3.Text == "O" && label6.Text == "O" && label7.Text == "O")//vert
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O") //horizontal
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else if (label4.Text == "O" && label5.Text == "O" && label6.Text == "O")//horizontal
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else if (label9.Text == "O" && label8.Text == "O" && label7.Text == "O")//horizontal
            { label10.Text += " Winner Player 2!"; foundWinner = true; }
            else
            {
                if (num == 10)
                {
                    label10.Text += " Draw";
                    foundWinner = true;
                }
            }
        }
        #endregion

        #region "Label Click Event"
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

           // if (num == 10)
            //{ checkWinner(); }
            checkWinner();
            if (foundWinner == true)
            { endGame(); }
        }
        #endregion

        #region "Quit Button"
        private void btnQuit_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        #endregion
    }
}
