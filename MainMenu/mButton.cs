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
    public partial class mButton : System.Windows.Forms.Button
    {
        public mButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        //adding properties to a button
        private int id;
        public int ID { get { return id; } set { id = value; } }

        private bool flipped;
        public bool isFlipped { get { return flipped; } set { flipped = value; } }

        private string triviaText;
        public string gameText { get { return triviaText; } set { triviaText = value; } }
    }
}
