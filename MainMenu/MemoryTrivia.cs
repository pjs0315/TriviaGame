/*
 * Name of table in DB: TriviaQuestions
 * Schema: CREATE TABLE TriviaQuestions(id integer primary key, question text, answer text);
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

        private void ButtonClick(object sender, EventArgs e)
        {
            mButton clickedButton = (mButton)sender;
            clickedButton.isFlipped = true;
            clickedButton.Text = clickedButton.gameText;
            //clickedButton.Text = "Clicked";
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
                    textBox1.Text += " ID: "+intArr[arrayCounter];

                    string question = row["question"].ToString();
                    qArr[arrayCounter] = question;
                    textBox1.Text += " Question: ";
                    textBox1.Text += qArr[arrayCounter];

                    string ans = row["answer"].ToString();
                    ansArr[arrayCounter] = ans;
                    textBox1.Text += " Answer: ";
                    textBox1.Text += ansArr[arrayCounter];
                    textBox1.Text += "                         ";
                }
                ++arrayCounter;
            }
            arrayCounter = 0; //resetting arrayCounter

            //adding all buttons to a single event handler called ButtonClick
            int buttonCounter = 0;
            foreach (Control c in this.Controls)
            {
                if (c is mButton)
                {
                    c.Click += ButtonClick;
                    ++buttonCounter;
                
                }
                
            }

            for (int j = 0; j < qArr.Length; ++j) { textBox2.Text += j + ". " + qArr[j] + "  "; }
            for (int j = 0; j < intArr.Length; ++j) { textBox2.Text += j + ". " + intArr[j] + "  "; }
            for (int j = 0; j < ansArr.Length; ++j) { textBox2.Text += j + ". " + ansArr[j] + "  "; }
           // textBox1.Text += "Adding Buttons:   "+ buttonCounter + "   ";

            int whichButton = 0;
            foreach (Control c in this.Controls)
            {
                textBox1.Text += "Array Counter: " + arrayCounter;
                if (c is mButton)
                {                      
                    if (whichButton == 0 && arrayCounter < 10)
                    {
                        mButton btn = (mButton)c;
                        btn.gameText = qArr[arrayCounter];
                        btn.ID = intArr[arrayCounter];
                        textBox1.Text += "Name: " + btn.Name + " ID: " + btn.ID + " Game Text: " + btn.gameText + "          ";
                        whichButton = 1;
                    }
                    if (whichButton == 1)
                    {
                        mButton btn = (mButton)c;
                        btn.gameText = ansArr[arrayCounter];
                        btn.ID = intArr[arrayCounter];
                        whichButton = 0;                               
                    }                                                                                                        
                }

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
    }
}
