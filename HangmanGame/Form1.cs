using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGame
{
    public partial class HangmanForm : Form
    {
        private string[] words = { "programming", "computer", "algorithm", "software", "developer" };
        private Random random = new Random();
        private string word;
        private char[] guessed;
        private int tries;
        private const int maxTries = 6;

        public HangmanForm()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            word = words[random.Next(words.Length)];
            guessed = new char[word.Length * 2 - 1];
            for (int i = 0; i < guessed.Length; i += 2)
            {
                guessed[i] = '_';
            }
            for (int i = 1; i < guessed.Length; i += 2)
            {
                guessed[i] = ' ';
            }
            tries = 0;
            UpdateUI();
            endLabel.Visible = false;
            newGameButton.Visible = true;
        }

        private void SubmitGuess()
        {
            char input = guessTextBox.Text.ToLower()[0];
            bool found = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == input)
                {
                    guessed[i] = input;
                    found = true;
                }
            }
            if (!found)
            {
                tries++;
            }
            UpdateUI();
            if (new string(guessed) == word)
            {
                MessageBox.Show("Congratulations! You guessed the word!");
                NewGame();
            }
            else if (tries == maxTries)
            {
                MessageBox.Show("Game over! The word was " + word);
                endLabel.Visible = true;
                newGameButton.Visible = true;
            }
        }

        private void UpdateUI()
        {
            wordLabel.Text = new string(guessed).ToUpper();
            triesLabel.Text = "Tries left: " + (maxTries - tries);
            switch (tries)
            {
                case 0:
                    hangmanPictureBox.Image = Image.FromFile(@"C:\Users\solis\source\repos\HangmanGame\HangmanGame\Images\hangman0.png");
                    break;
                case 1:
                    hangmanPictureBox.Image = Image.FromFile(@"C:\Users\solis\source\repos\HangmanGame\HangmanGame\Images\hangman1.png");
                    break;
                case 2:
                    hangmanPictureBox.Image = Image.FromFile(@"C:\Users\solis\source\repos\HangmanGame\HangmanGame\Images\hangman2.png");
                    break;
                case 3:
                    hangmanPictureBox.Image = Image.FromFile(@"C:\Users\solis\source\repos\HangmanGame\HangmanGame\Images\hangman3.png");
                    break;
                case 4:
                    hangmanPictureBox.Image = Image.FromFile(@"C:\Users\solis\source\repos\HangmanGame\HangmanGame\Images\hangman4.png");
                    break;
                case 5:
                    hangmanPictureBox.Image = Image.FromFile(@"C:\Users\solis\source\repos\HangmanGame\HangmanGame\Images\hangman5.png");
                    break;
                case 6:
                    hangmanPictureBox.Image = Image.FromFile(@"C:\Users\solis\source\repos\HangmanGame\HangmanGame\Images\hangman6.png");
                    break;
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            SubmitGuess();
            guessTextBox.Text = "";
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            endLabel.Visible = false;
            newGameButton.Visible = false;
            NewGame();
        }

        private void guessButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            SubmitGuess();
            guessTextBox.Text = "";
        }
    }
}
