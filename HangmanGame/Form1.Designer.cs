namespace HangmanGame
{
    partial class HangmanForm
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
            this.triesLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.wordLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.hangmanPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // triesLabel
            // 
            this.triesLabel.AutoSize = true;
            this.triesLabel.Location = new System.Drawing.Point(186, 349);
            this.triesLabel.Name = "triesLabel";
            this.triesLabel.Size = new System.Drawing.Size(0, 13);
            this.triesLabel.TabIndex = 0;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(297, 328);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(0, 13);
            this.endLabel.TabIndex = 0;
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordLabel.Location = new System.Drawing.Point(143, 85);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(0, 73);
            this.wordLabel.TabIndex = 0;
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(189, 365);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(266, 20);
            this.guessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(461, 354);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 40);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Submit";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            this.guessButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guessButton_KeyPress);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(795, 299);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // hangmanPictureBox
            // 
            this.hangmanPictureBox.Location = new System.Drawing.Point(710, 27);
            this.hangmanPictureBox.Name = "hangmanPictureBox";
            this.hangmanPictureBox.Size = new System.Drawing.Size(244, 266);
            this.hangmanPictureBox.TabIndex = 3;
            this.hangmanPictureBox.TabStop = false;
            // 
            // HangmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 432);
            this.Controls.Add(this.hangmanPictureBox);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.triesLabel);
            this.Name = "HangmanForm";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label triesLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.PictureBox hangmanPictureBox;
    }
}

