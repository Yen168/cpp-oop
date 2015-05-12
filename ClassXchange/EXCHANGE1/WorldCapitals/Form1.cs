using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WorldCapitals
{
    public partial class Form1 : Form
    {
        int Score = 0;
        int CorrectOptionBox;

        public Form1()
        {
            InitializeComponent();
        }

        void AskQuestion()
        {
            //build a connection string
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MONDIAL.accdb;Jet OLEDB:Database Password=password";
            
            //connect to database
            DataSet data = new DataSet();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Country", connStr);
            adap.Fill(data);

            //get the number of coutries in the database
            int countryCount = data.Tables[0].Rows.Count;

            //randomly pick a country
            Random random = new Random();
            int correctAnswer = random.Next(0, countryCount -1);
            int wrongAnswer = random.Next(0, countryCount - 1);

            //get the CountryName and its Capital based on the random rumbers
            string questionCountryName = data.Tables[0].Rows[correctAnswer]["CountryName"].ToString();
            string questionCorrectCapital = data.Tables[0].Rows[correctAnswer]["Capital"].ToString();
            string questionWrongCapital = data.Tables[0].Rows[wrongAnswer]["Capital"].ToString();

            // form the question using the country name
            lblQuestion.Text = "What is the capital of " + questionCountryName + "?";

            //decide which box be the correct one based on the current milliseconds
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                optChoice1.Text = questionCorrectCapital;
                optChoice2.Text = questionWrongCapital;
                CorrectOptionBox = 1;
            }
            else 
            {
                optChoice1.Text = questionWrongCapital;
                optChoice2.Text = questionCorrectCapital;
                CorrectOptionBox = 2;
            }
        }
        
        void EvaluateAnswer() 
        {
            //give a score feedback
            if ((CorrectOptionBox == 1 && optChoice1.Checked) || (CorrectOptionBox == 2 && optChoice2.Checked))
                Score += 10; // correct answer
            else
                Score -= 10; // wrong

            // current score
            lblScore.Text = "Your Score is " + Score.ToString();

            //ask another question
            AskQuestion();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AskQuestion();
            lblScore.Text = "Let's Go!!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EvaluateAnswer();
        }
    }
}
