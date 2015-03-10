namespace Hangman
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.labelLetter1 = new System.Windows.Forms.Label();
            this.labelLetter2 = new System.Windows.Forms.Label();
            this.labelLetter3 = new System.Windows.Forms.Label();
            this.labelLetter4 = new System.Windows.Forms.Label();
            this.labelLetter5 = new System.Windows.Forms.Label();
            this.labelLetter6 = new System.Windows.Forms.Label();
            this.labelLetter7 = new System.Windows.Forms.Label();
            this.labelLetter8 = new System.Windows.Forms.Label();
            this.picHangManBox = new System.Windows.Forms.PictureBox();
            this.labelGameInfo = new System.Windows.Forms.Label();
            this.labelGuessedLetters = new System.Windows.Forms.Label();
            this.tipGuessedLetters = new System.Windows.Forms.ToolTip(this.components);
            this.tboxGuessLetter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxGuessWord = new System.Windows.Forms.TextBox();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.difficultySelector = new System.Windows.Forms.ComboBox();
            this.wordLengthSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHangManBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLetter1
            // 
            this.labelLetter1.BackColor = System.Drawing.Color.White;
            this.labelLetter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter1.Location = new System.Drawing.Point(12, 242);
            this.labelLetter1.Name = "labelLetter1";
            this.labelLetter1.Size = new System.Drawing.Size(55, 66);
            this.labelLetter1.TabIndex = 0;
            this.labelLetter1.Text = "A";
            this.labelLetter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLetter2
            // 
            this.labelLetter2.BackColor = System.Drawing.Color.White;
            this.labelLetter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter2.Location = new System.Drawing.Point(73, 242);
            this.labelLetter2.Name = "labelLetter2";
            this.labelLetter2.Size = new System.Drawing.Size(55, 66);
            this.labelLetter2.TabIndex = 1;
            this.labelLetter2.Text = "B";
            this.labelLetter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLetter3
            // 
            this.labelLetter3.BackColor = System.Drawing.Color.White;
            this.labelLetter3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter3.Location = new System.Drawing.Point(134, 242);
            this.labelLetter3.Name = "labelLetter3";
            this.labelLetter3.Size = new System.Drawing.Size(55, 66);
            this.labelLetter3.TabIndex = 2;
            this.labelLetter3.Text = "C";
            this.labelLetter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLetter4
            // 
            this.labelLetter4.BackColor = System.Drawing.Color.White;
            this.labelLetter4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter4.Location = new System.Drawing.Point(195, 242);
            this.labelLetter4.Name = "labelLetter4";
            this.labelLetter4.Size = new System.Drawing.Size(55, 66);
            this.labelLetter4.TabIndex = 3;
            this.labelLetter4.Text = "D";
            this.labelLetter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLetter5
            // 
            this.labelLetter5.BackColor = System.Drawing.Color.White;
            this.labelLetter5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter5.Location = new System.Drawing.Point(256, 242);
            this.labelLetter5.Name = "labelLetter5";
            this.labelLetter5.Size = new System.Drawing.Size(55, 66);
            this.labelLetter5.TabIndex = 4;
            this.labelLetter5.Text = "E";
            this.labelLetter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLetter6
            // 
            this.labelLetter6.BackColor = System.Drawing.Color.White;
            this.labelLetter6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter6.Location = new System.Drawing.Point(317, 242);
            this.labelLetter6.Name = "labelLetter6";
            this.labelLetter6.Size = new System.Drawing.Size(55, 66);
            this.labelLetter6.TabIndex = 5;
            this.labelLetter6.Text = "F";
            this.labelLetter6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLetter7
            // 
            this.labelLetter7.BackColor = System.Drawing.Color.White;
            this.labelLetter7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter7.Location = new System.Drawing.Point(378, 242);
            this.labelLetter7.Name = "labelLetter7";
            this.labelLetter7.Size = new System.Drawing.Size(55, 66);
            this.labelLetter7.TabIndex = 6;
            this.labelLetter7.Text = "G";
            this.labelLetter7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLetter8
            // 
            this.labelLetter8.BackColor = System.Drawing.Color.White;
            this.labelLetter8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLetter8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetter8.Location = new System.Drawing.Point(439, 242);
            this.labelLetter8.Name = "labelLetter8";
            this.labelLetter8.Size = new System.Drawing.Size(55, 66);
            this.labelLetter8.TabIndex = 7;
            this.labelLetter8.Text = "H";
            this.labelLetter8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picHangManBox
            // 
            this.picHangManBox.Image = ((System.Drawing.Image)(resources.GetObject("picHangManBox.Image")));
            this.picHangManBox.Location = new System.Drawing.Point(12, 12);
            this.picHangManBox.Name = "picHangManBox";
            this.picHangManBox.Size = new System.Drawing.Size(482, 227);
            this.picHangManBox.TabIndex = 8;
            this.picHangManBox.TabStop = false;
            // 
            // labelGameInfo
            // 
            this.labelGameInfo.BackColor = System.Drawing.Color.White;
            this.labelGameInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGameInfo.Location = new System.Drawing.Point(134, 325);
            this.labelGameInfo.Name = "labelGameInfo";
            this.labelGameInfo.Size = new System.Drawing.Size(360, 56);
            this.labelGameInfo.TabIndex = 35;
            this.labelGameInfo.Text = "Various information about the game will display here.";
            this.labelGameInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuessedLetters
            // 
            this.labelGuessedLetters.BackColor = System.Drawing.Color.White;
            this.labelGuessedLetters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessedLetters.Location = new System.Drawing.Point(12, 325);
            this.labelGuessedLetters.Name = "labelGuessedLetters";
            this.labelGuessedLetters.Size = new System.Drawing.Size(116, 56);
            this.labelGuessedLetters.TabIndex = 36;
            this.labelGuessedLetters.Text = "ABCDEGHJ";
            this.labelGuessedLetters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tipGuessedLetters.SetToolTip(this.labelGuessedLetters, "These are letters you have already guessed and were incorrect.");
            // 
            // tboxGuessLetter
            // 
            this.tboxGuessLetter.Location = new System.Drawing.Point(317, 388);
            this.tboxGuessLetter.MaxLength = 1;
            this.tboxGuessLetter.Name = "tboxGuessLetter";
            this.tboxGuessLetter.Size = new System.Drawing.Size(74, 20);
            this.tboxGuessLetter.TabIndex = 37;
            this.tboxGuessLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Guess Letter:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(245, 439);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(147, 23);
            this.buttonSubmit.TabIndex = 39;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Guess Word:";
            // 
            // tboxGuessWord
            // 
            this.tboxGuessWord.Location = new System.Drawing.Point(317, 413);
            this.tboxGuessWord.MaxLength = 8;
            this.tboxGuessWord.Name = "tboxGuessWord";
            this.tboxGuessWord.Size = new System.Drawing.Size(74, 20);
            this.tboxGuessWord.TabIndex = 41;
            this.tboxGuessWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(12, 438);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(116, 23);
            this.buttonNewGame.TabIndex = 42;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // difficultySelector
            // 
            this.difficultySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultySelector.FormattingEnabled = true;
            this.difficultySelector.Items.AddRange(new object[] {
            "Normal",
            "Easy"});
            this.difficultySelector.Location = new System.Drawing.Point(12, 411);
            this.difficultySelector.Name = "difficultySelector";
            this.difficultySelector.Size = new System.Drawing.Size(116, 21);
            this.difficultySelector.TabIndex = 43;
            // 
            // wordLengthSelector
            // 
            this.wordLengthSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wordLengthSelector.FormattingEnabled = true;
            this.wordLengthSelector.Items.AddRange(new object[] {
            "Any",
            "3+",
            "4+",
            "5+",
            "6+",
            "7+",
            "8"});
            this.wordLengthSelector.Location = new System.Drawing.Point(87, 384);
            this.wordLengthSelector.Name = "wordLengthSelector";
            this.wordLengthSelector.Size = new System.Drawing.Size(41, 21);
            this.wordLengthSelector.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Word Length:";
            // 
            // mainForm
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wordLengthSelector);
            this.Controls.Add(this.difficultySelector);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.tboxGuessWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxGuessLetter);
            this.Controls.Add(this.labelGuessedLetters);
            this.Controls.Add(this.labelGameInfo);
            this.Controls.Add(this.picHangManBox);
            this.Controls.Add(this.labelLetter8);
            this.Controls.Add(this.labelLetter7);
            this.Controls.Add(this.labelLetter6);
            this.Controls.Add(this.labelLetter5);
            this.Controls.Add(this.labelLetter4);
            this.Controls.Add(this.labelLetter3);
            this.Controls.Add(this.labelLetter2);
            this.Controls.Add(this.labelLetter1);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHangManBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLetter1;
        private System.Windows.Forms.Label labelLetter2;
        private System.Windows.Forms.Label labelLetter3;
        private System.Windows.Forms.Label labelLetter4;
        private System.Windows.Forms.Label labelLetter5;
        private System.Windows.Forms.Label labelLetter6;
        private System.Windows.Forms.Label labelLetter7;
        private System.Windows.Forms.Label labelLetter8;
        private System.Windows.Forms.PictureBox picHangManBox;
        private System.Windows.Forms.Label labelGameInfo;
        private System.Windows.Forms.Label labelGuessedLetters;
        private System.Windows.Forms.ToolTip tipGuessedLetters;
        private System.Windows.Forms.TextBox tboxGuessLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxGuessWord;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.ComboBox difficultySelector;
        private System.Windows.Forms.ComboBox wordLengthSelector;
        private System.Windows.Forms.Label label3;
    }
}

