using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    public partial class mainForm : Form
    {
        public List<String> wordList = new List<String>();
        public string currentWord = "";
        public int lives;
        public int slide;
        public int filterLength;
        public string diffMode;

        public List<Image> slides = new List<Image>();
        public List<char> letterBank = new List<char>();

        public mainForm()
        {
            try
            {
                //Reads wordlist.txt and puts all words on the list into wordList.
                using (StreamReader reader = new StreamReader("wordlist.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        wordList.Add(line);
                        Console.WriteLine("Added " + line + " to wordList");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not find wordlist.txt, please make sure it exists within the program's debug folder.");
            }


            filterLength = 0;
            InitializeComponent();
            difficultySelector.Text = "Normal";
            int i = 1;
            while (i <= 12)
            {
                slides.Add(Image.FromFile("images/slides/hmanslide" + i + ".png"));
                i++;
            }
            picHangManBox.Image = slides[0];
            slide = 0;
            ResetGame();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //na
        }

        private void ResetGame()
        {
            int run = 0;
            currentWord = "";
            slide = 0;
            picHangManBox.Image = slides[0];
            letterBank.Clear();

            labelLetter1.Text = "";
            labelLetter2.Text = "";
            labelLetter3.Text = "";
            labelLetter4.Text = "";
            labelLetter5.Text = "";
            labelLetter6.Text = "";
            labelLetter7.Text = "";
            labelLetter8.Text = "";

            labelGameInfo.Text = "";
            labelGuessedLetters.Text = "";

            ResetLabels();
            diffMode = difficultySelector.Text;
            if (diffMode == "Easy")
            {
                lives = 12;
            }
            else if (diffMode == "Normal")
            {
                lives = 7;
            }
            else
            {
                MessageBox.Show("Something weird happened with the difficulty selector.");
            }

            if (wordLengthSelector.Text == "Any" || wordLengthSelector.Text == "")
            {
                filterLength = 0;
            }
            else if (wordLengthSelector.Text == "3+")
            {
                filterLength = 3;
            }
            else if (wordLengthSelector.Text == "4+")
            {
                filterLength = 4;
            }
            else if (wordLengthSelector.Text == "5+")
            {
                filterLength = 5;
            }
            else if (wordLengthSelector.Text == "6+")
            {
                filterLength = 6;
            }
            else if (wordLengthSelector.Text == "7+")
            {
                filterLength = 7;
            }
            else if (wordLengthSelector.Text == "8")
            {
                filterLength = 8;
            }

            if (currentWord.Length < 3 || currentWord == "" || currentWord.Length > 8)
            {
                currentWord = GenerateWord();
                if (run > 0)
                {
                    Console.WriteLine("Tried to pull invalid word: " + currentWord);
                }
                run++;
            }

            if (currentWord.Length == 3)
            {
                labelLetter4.BackColor = Color.Gray;
                labelLetter5.BackColor = Color.Gray;
                labelLetter6.BackColor = Color.Gray;
                labelLetter7.BackColor = Color.Gray;
                labelLetter8.BackColor = Color.Gray;
            }
            else if (currentWord.Length == 4)
            {
                labelLetter5.BackColor = Color.Gray;
                labelLetter6.BackColor = Color.Gray;
                labelLetter7.BackColor = Color.Gray;
                labelLetter8.BackColor = Color.Gray;
            }
            else if (currentWord.Length == 5)
            {
                labelLetter6.BackColor = Color.Gray;
                labelLetter7.BackColor = Color.Gray;
                labelLetter8.BackColor = Color.Gray;
            }
            else if (currentWord.Length == 6)
            {
                labelLetter7.BackColor = Color.Gray;
                labelLetter8.BackColor = Color.Gray;
            }
            else if (currentWord.Length == 7)
            {
                labelLetter8.BackColor = Color.Gray;
            }
            else if (currentWord.Length == 8)
            {
                //All word labels should be white.
            }
            else
            {
                MessageBox.Show("Current word did not fit parameters.");
            }

            UpdateGameInfo();
        }

        private string GenerateWord()
        {
            string result;

            //Selects a random word from wordList and returns the function with that word.
            Random rand = new Random();
            int index = rand.Next(wordList.Count);
            result = wordList[index];
            while (result.Length < filterLength)
            {
                index = rand.Next(wordList.Count);
                result = wordList[index];
            }
            return result;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string currentGuessLetter = tboxGuessLetter.Text;
            string currentGuessWord = tboxGuessWord.Text;

            currentGuessLetter = currentGuessLetter.ToLower();
            currentGuessWord = currentGuessWord.ToLower();

            if (currentGuessLetter != "" && currentGuessWord != "") //If user is attempting to guess both the word and a letter.
            {
                MessageBox.Show("Can't guess both a letter and a word.");
                currentGuessLetter = "";
                currentGuessWord = "";
            }
            else if (currentGuessWord == "" && currentGuessLetter != "") //If just guessing a letter.
            {
                if (currentWord.IndexOf(currentGuessLetter) == -1)
                {
                    //Did not guess a correct letter.
                    if (letterBank.IndexOf(Convert.ToChar(currentGuessLetter)) == -1)
                    {
                        labelGuessedLetters.Text = labelGuessedLetters.Text + currentGuessLetter;
                        letterBank.Add(Convert.ToChar(currentGuessLetter));
                        LoseLife();
                    }
                }
                else
                {
                    //Guessed a correct letter.
                    int i = 0;
                    while ((i = currentWord.IndexOf(Convert.ToChar(currentGuessLetter), i)) != -1)
                    {
                        RevealLetter(i);
                        i++;
                    }
                    CheckForWin();
                }
            }
            else if (currentGuessWord != "" && currentGuessLetter == "") //If just guessing the word.
            {
                if (currentGuessWord == currentWord)
                {
                    YouWin();
                }
                else if (currentGuessWord == "tellme")
                {
                    MessageBox.Show(currentWord);
                }
                else
                {
                    MessageBox.Show("Did not guess word.");
                }
            }
            tboxGuessLetter.Text = "";
            tboxGuessWord.Text = "";
        }

        private void LoseLife()
        {
            slide++;
            lives -= 1;
            UpdateGameInfo();
            if (lives <= 0)
            {
                YouLose();
            }
            picHangManBox.Image = slides[slide];
        }

        private void RevealLetter(int location)
        {
            if (location == 0)
            {
                labelLetter1.Text = currentWord[0].ToString();
            }
            else if (location == 1)
            {
                labelLetter2.Text = currentWord[1].ToString();
            }
            else if (location == 2)
            {
                labelLetter3.Text = currentWord[2].ToString();
            }
            else if (location == 3)
            {
                labelLetter4.Text = currentWord[3].ToString();
            }
            else if (location == 4)
            {
                labelLetter5.Text = currentWord[4].ToString();
            }
            else if (location == 5)
            {
                labelLetter6.Text = currentWord[5].ToString();
            }
            else if (location == 6)
            {
                labelLetter7.Text = currentWord[6].ToString();
            }
            else if (location == 7)
            {
                labelLetter8.Text = currentWord[7].ToString();
            }
            else
            {
                MessageBox.Show("Error in RevealLetter");
            }
        }

        private void ResetLabels()
        {
            labelLetter1.BackColor = Color.White;
            labelLetter2.BackColor = Color.White;
            labelLetter3.BackColor = Color.White;
            labelLetter4.BackColor = Color.White;
            labelLetter5.BackColor = Color.White;
            labelLetter6.BackColor = Color.White;
            labelLetter7.BackColor = Color.White;
            labelLetter8.BackColor = Color.White;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void UpdateGameInfo()
        {
            labelGameInfo.Text = "You have " + lives + " guesses left.";
        }

        private bool CheckForWin()
        {
            //Checks number of lives and whether all the letters have been guessed.
            int boxesNeeded = currentWord.Length;
            int i = 0;
            while (i < boxesNeeded)
            {
                if (labelLetter1.Text != "" && i == 0)
                {
                    i++;
                }
                if (labelLetter2.Text != "" && i == 1)
                {
                    i++;
                }
                if (labelLetter3.Text != "" && i == 2)
                {
                    i++;
                }
                if (labelLetter4.Text != "" && i == 3)
                {
                    i++;
                }
                if (labelLetter5.Text != "" && i == 4)
                {
                    i++;
                }
                if (labelLetter6.Text != "" && i == 5)
                {
                    i++;
                }
                if (labelLetter7.Text != "" && i == 6)
                {
                    i++;
                }
                if (labelLetter8.Text != "" && i == 7)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            if (i >= boxesNeeded)
            {
                YouWin();
            }

            return false;
        }

        private void YouLose()
        {
            //When the user runs out of lives/guesses.
            MessageBox.Show("You ran out of lives. The word was " + currentWord + ".");
            ResetGame();
        }

        private void YouWin()
        {
            //When the user guesses all the letters or the word.
            MessageBox.Show("You guessed the word correctly!");
            ResetGame();
        }
    }
}
