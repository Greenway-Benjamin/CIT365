using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        //Create randomizer
        Random randomizer = new Random();

        //Create integers to store random addition numbers
        int addend1, addend2;

        //Create integers to store random subtraction numbers
        int minuend, subtrahend;

        //Create integers to store random multiplier numbers
        int multiplicand, multiplier;

        //Create integers to store random division numbers
        int dividend, divisor;

        //Integer to keep track of time
        int timeLeft;

        //Fill in all problems and start timer
        public void StartTheQuiz()
        {
            //Generate random numbers and store them in variables
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Convert ints to strings to display them in the boxes
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //Set sum value to 0. Just in case.
            sum.Value = 0;

            //Fill in subtraction problem
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            //Fill in multiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //Fill in division problem
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //Start timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Today.ToString("dd MMMM yyyy");
        }

        private void checkAddRight(object sender, EventArgs e)
        {
            if (addend1 + addend2 == sum.Value)
            {
                System.Media.SystemSounds.Asterisk.Play();
                sum.BackColor = Color.LightGreen;
            }
            else sum.BackColor = default(Color);
        }
        private void checkMinusRight(object sender, EventArgs e)
        {
            if (minuend - subtrahend == difference.Value)
            {
                System.Media.SystemSounds.Asterisk.Play();
                difference.BackColor = Color.LightGreen;
            }
            else difference.BackColor = default(Color);
        }
        private void checkMultiplyRight(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                System.Media.SystemSounds.Asterisk.Play();
                product.BackColor = Color.LightGreen;
            }
            else product.BackColor = default(Color);
        }
        private void checkDivisionRight(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
            {
                System.Media.SystemSounds.Asterisk.Play();
                quotient.BackColor = Color.LightGreen;
            }
            else quotient.BackColor = default(Color);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //Start quiz and disable start button
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (CheckTheAnswer())
            {
                //If answer is correct stop timer and show good job message
                timer1.Stop();
                changeColorsBack();
                MessageBox.Show("You got all the answers right!", "Congratulations");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                //Display time left by updating timeLeft label
                timeLeft--;

                //When time is at five seconds timer turns red
                if (timeLeft <= 5)
                    timeLabel.BackColor = Color.Red;

                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //If user is out of time, stop quiz and fill in answers
                timer1.Stop();
                changeColorsBack();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void changeColorsBack()
        {
            timeLabel.BackColor = default(Color);
            sum.BackColor = default(Color);
            difference.BackColor = default(Color);
            product.BackColor = default(Color);
            quotient.BackColor = default(Color);
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
