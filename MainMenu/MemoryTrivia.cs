/*
 * Name of table in DB: TriviaQuestions
 * Schema: CREATE TABLE TriviaQuestions(id integer primary key, question text, answer text);
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Threading;

namespace MainMenu
{
    public partial class MemoryTrivia : Form
    {

        #region "DB Connection Initial"

        //connecting to DB        
        static string fileDB = "questions.db";
        static string fullPath = Path.GetFullPath(fileDB);//getting path of db

        static string connStr = @"Data Source="+fullPath+";Version=3;";
        SQLiteConnection connection = new SQLiteConnection(connStr);
        SQLiteDataAdapter dataApt;
        DataTable tbl = new DataTable();
        SQLiteCommand cmd;
        #endregion

        public MemoryTrivia()
        {
            InitializeComponent();
        }

        #region "Button Click for All Buttons"

        int[] ids = new int[2] { 0, 0 };
        int numClick = 0;
        mButton prev;
        mButton curr;
        int winCounter = 10;
       
        private void ButtonClick(object sender, EventArgs e)
        {
            mButton clickedButton = sender as mButton;
            clickedButton.Text = clickedButton.gameText;
            ++numClick;
            
            switch (numClick)
            {
                case 1: ids[0] = clickedButton.ID;
                    prev = clickedButton;
                    break;
                case 2:
                    ids[1] = clickedButton.ID;
                    curr = clickedButton;

                    if (ids[0] == ids[1])//match found
                    { prev.Enabled = false; clickedButton.Enabled = false; --winCounter; }
                    else
                    { timer1.Start();} //no match found

                    numClick = 0;
                    break;
            }
            if (winCounter == 0)
            { label1.Text = "You found all the matches!"; }
        }
        #endregion

        #region "Loading Trivia"
        private void MemoryTrivia_Load(object sender, EventArgs e)
        {
            //appears to have fixed casting issue
            foreach (Control c in this.Controls   )
            {
                if (c is mButton)
                {
                    c.Text = "";
                }
            }
            
            //connect to DB
            connection.Open();

            //load from database in random order
            dataApt = new SQLiteDataAdapter("SELECT * FROM TriviaQuestions ORDER BY RANDOM() LIMIT 10", connection);//change table to proper table name
            dataApt.Fill(tbl);

            //Holds question data
            string[] qArr = new string[10]; 

            //Holds answer data
            string[] ansArr = new string[10];

            //Holds row id data
            int[] intArr = new int[10];

            int arrayCounter = 0;

            //Storing data from DB into arrays
            foreach (DataRow row in tbl.Rows)
            {
                if (arrayCounter < 10)//only 10 questions, don't want to go over limit
                {
                    int id = Convert.ToInt32(row["id"]);
                    intArr[arrayCounter] = id;

                    string question = row["question"].ToString();
                    qArr[arrayCounter] = question;

                    string ans = row["answer"].ToString();
                    ansArr[arrayCounter] = ans;
                }
                ++arrayCounter;
            }
            arrayCounter = 0; //resetting arrayCounter

            for (int i = 1; i < 21; ++i)
            {
                string name = "mButton" + i;
                Control b = this.Controls.Find(name, true).FirstOrDefault() as mButton;
                mButton btn = (mButton)b;
                if (i <= 10)
                { btn.gameText = qArr[i - 1]; btn.ID = intArr[i - 1]; }
                if (i > 10)
                { btn.gameText = ansArr[i - 11]; btn.ID = intArr[i - 11]; }

            }
        }
#endregion

        #region "Back to Main Menu Button"
        private void btnQuitToMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
            this.Close();
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            prev.Text = ""; curr.Text = "";
            
           
        }
    }
}
