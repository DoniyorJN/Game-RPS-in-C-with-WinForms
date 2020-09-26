using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RockPaperScissoesGame
{
    
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        private int userScore = 0;
        private int computerScore = 0;
        //***********************functions**************************
        private void disableExceptPlay()
        {
            paperButton.Enabled = false;
            rockButton.Enabled = false;
            scissoesButton.Enabled = false;
            playButton.Enabled = true;
        }

        private void enableExceptPlay()
        {
            paperButton.Enabled = true;
            rockButton.Enabled = true;
            scissoesButton.Enabled = true;
            playButton.Enabled = false;
        }

        private int changePhoto()
        {
            Random rand = new Random();
            int numberGeneratedFromRandForComputers = rand.Next(3);
            computerPictureBox.Image = gameImageList.Images[numberGeneratedFromRandForComputers];
            return numberGeneratedFromRandForComputers;
        }

        private void whoWins(int users, int computer)
        {
            int  paper=0, rock=1, scissoes=2;
            if (users == computer)
            {
                resultsLabel.Text = "DRAW Choise again";
                scoreLabel.Text = $"{userScore,2} : {computerScore,2}";
            }
            else if ((users==paper && computer==rock) || (users==scissoes && computer==paper) || (users == rock && computer == scissoes))
            {
                resultsLabel.Text = "You win!!!!";
                scoreLabel.Text = $"{++userScore,2} : {computerScore,2}";
                disableExceptPlay();
            }
            else
            {
                resultsLabel.Text = "You lose";
                scoreLabel.Text = $"{userScore,2} : {++computerScore,2}";
                disableExceptPlay();
            }
        }
        ///************************Clicks****************************
        private void PlayButton_Click(object sender, EventArgs e)
        {
            enableExceptPlay();
            resultsLabel.Text = "";
        }
       
        private void PaperButton_Click(object sender, EventArgs e)
        {
            
            playerPictureBox.Image = gameImageList.Images[0];
            whoWins(0,changePhoto());
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            
            playerPictureBox.Image = gameImageList.Images[1];
            whoWins(1, changePhoto());
        }

        private void ScissoesButton_Click(object sender, EventArgs e)
        {
            playerPictureBox.Image = gameImageList.Images[2];
            whoWins(2, changePhoto());
        }
    }
}
