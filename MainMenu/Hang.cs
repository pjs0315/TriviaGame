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
        char userAnswer = ' ';
        int strikes = 9;
        char[] charArray;   

        public frmHang()
        {
            InitializeComponent();
        }

        private void btnCheckChar_Click(object sender, EventArgs e)
        {
            //userAnswer = Convert.ToChar(textBox1.Text);
            charArray = new char[word.Length];

            int counter = 0;
            foreach (char c in word)
            {
                charArray[counter] = c;
                ++counter;
            }

            string s = new string(charArray);
            textBox1.Text = s;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}
