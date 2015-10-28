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
    public partial class MemoryTrivia : Form
    {
        public MemoryTrivia()
        {
            InitializeComponent();
        }


        private void ButtonClick(object sender, EventArgs e)
        {
            Button whichButton = (Button)sender; 

     
        }

        private void MemoryTrivia_Load(object sender, EventArgs e)
        {
           foreach (Button b in this.Controls)
            {
                b.Text = "Green";
            }
        }

        private void btnQuitToMain_Click(object sender, EventArgs e)
        {
           // frmMain main = new frmMain();
            this.Hide();
           // main.Show();
            this.Close();
            

        }
    }
}
