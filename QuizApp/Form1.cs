using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        //variables
        int cAnswer;
        int qNumber = 1;
        int score;
        int totalQuestions;


        public Form1()
        {
            InitializeComponent();

            askQuestion(qNumber);
            totalQuestions = 8;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == cAnswer)
            {
                score++;
            }
            if (qNumber == totalQuestions)
            {


                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +

              
                    );
                score = 0;
                qNumber = 0;
                askQuestion(qNumber);
            }
            qNumber++;
            askQuestion(qNumber);
        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.gdansk;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Gdansk";
                    button2.Text = "Bydgoszcz";
                    button3.Text = "Torun";
                    cAnswer = 1;

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.lodz;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Warsawa";
                    button2.Text = "Szczecin";
                    button3.Text = "Lodz";

                    cAnswer = 3;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.bydgosh;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Wroclaw";
                    button2.Text = "Bydgoszcz";
                    button3.Text = "Torun";

                    cAnswer = 2;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.warsaw;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Szczecin";
                    button2.Text = "Warszawa";
                    button3.Text = "Gdynia";

                    cAnswer = 2;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.torun;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Torun";
                    button2.Text = "Poznan";
                    button3.Text = "Lublin";

                    cAnswer = 1;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.wroclaw;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Katowice";
                    button2.Text = "Poznan";
                    button3.Text = "Wroclaw";

                    cAnswer = 3;
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources.krakow;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Kielce";
                    button2.Text = "Wroclaw";
                    button3.Text = "Krakow";

                    cAnswer = 3;
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources.szczecin;
                    label1.Text = "Which city is demonstrated on the picture?";
                    button1.Text = "Birmingham";
                    button2.Text = "Sopot";
                    button3.Text = "Szczecin";

                    cAnswer = 3;
                    break;
            }

        }

       
    }
}
