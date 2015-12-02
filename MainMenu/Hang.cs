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
    public partial class frmHang : Form
    {
        string word = "test";
        char userAnswer = '1';
        int strikes = 1;
        char[] charArray;   

        public frmHang()
        {
            InitializeComponent();
        }

        private void btnCheckChar_Click(object sender, EventArgs e)
        {
             
            userAnswer = Convert.ToChar(textBox1.Text);           
            checkForChar();
        }

        #region "Check Character Match"

        private void checkForChar()
        {
            int index = 0;
            bool foundMatch = false;

            foreach (char ch in word)
            {
                if (ch == userAnswer)
                { 
                    charArray[index] = ch;
                    foundMatch = true;
                }
                ++index;
            }

            if (foundMatch == false)
            {
                switch (strikes)
                {
                    case 1: lblStand.Visible = true; ++strikes;
                        break;
                    case 2: lblPole.Visible = true; ++strikes;
                        break;
                    case 3: lblArm.Visible = true; ++strikes;
                        break;
                    case 4: lblHook.Visible = true; ++strikes;
                        break;
                    case 5: lblHead.Visible = true; ++strikes;
                        break;
                    case 6: lblBody.Visible = true; ++strikes;
                        break;
                    case 7: lblArmLeft.Visible = true; ++strikes;
                        break;
                    case 8: lblArmRight.Visible = true; ++strikes;
                        break;
                    case 9: lblLegLeft.Visible = true; ++strikes;
                        break;
                    case 10: lblLegRight.Visible = true; ++strikes; textBox1.Enabled = false; btnCheckChar.Enabled = false; lblGameOver.Text = "Game Over";
                        break;
                }
            }
            else if (foundMatch == true)
            {
                string s = new string(charArray);
                lblWord.Text = s;
            }

          
        }
        #endregion

        #region "Back to Main Button"

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        #endregion

        private void frmHang_Load(object sender, EventArgs e)
        {
            //loading and initializing
            charArray = new char[word.Length];
            for (int i = 0; i < word.Length; ++i)
            {
                charArray[i] = '_';
            }

            string s = new string(charArray);
            lblWord.Text = s;
        }
    }
}
