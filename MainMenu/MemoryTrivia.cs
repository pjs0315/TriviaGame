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

        //connecting to DB
        //C:\Users\Ani\Documents\GitHub\TriviaGame\MainMenu\bin\Debug
        static string fileDB = "questions.db";
        static string fullPath = Path.GetFullPath(fileDB);//getting path of db

        static string connStr = @"Data Source="+fullPath+";Version=3;";
        SQLiteConnection connection = new SQLiteConnection(connStr);
        SQLiteDataAdapter dataApt;
        DataTable tbl = new DataTable();
        SQLiteCommand cmd;

        public MemoryTrivia()
        {
            InitializeComponent();
        }


        private void ButtonClick(object sender, EventArgs e)
        {
            //Button whichButton = (Button)sender; 

            //when button is clicked, text appears
            //user clicks another button, text appears
            //compare the text on each button, if the answer matches the question, then buttons turn green, text stays, and button becomes disabled

            //click button, put what is in gameText into Text property

     
        }

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

            //example to load from DB
            /* sqlConn.Open();
                            comm = new SqlCommand("DELETE FROM Student WHERE StudentID = " + id, sqlConn);
                            sql.DeleteCommand = comm;
                            sql.DeleteCommand.ExecuteNonQuery();
                            sqlConn.Close();*/
            connection.Open();
            //load from database
            dataApt = new SQLiteDataAdapter("SELECT * FROM TriviaQuestions ORDER BY RANDOM() LIMIT 10", connection);//change table to proper table name
            dataApt.Fill(tbl);//filling datatable

            string[] qArr = new string[10];
            string[] ansArr = new string[10];
            int[] intArr = new int[10];
            int arrayCounter = 0;

            foreach (DataRow row in tbl.Rows)
            {
                if (arrayCounter < 10)
                {
                    int id = Convert.ToInt32(row["id"]);
                    intArr[arrayCounter] = id;

                    string question = row["question"].ToString();
                    qArr[arrayCounter] = question;

                    string ans = row["answer"].ToString();
                    ansArr[arrayCounter] = ans;
                }


            }                       
    
        }

        private void btnQuitToMain_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Hide();
            main.Show();
            this.Close();
            

        }
    }
}
