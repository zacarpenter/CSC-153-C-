namespace Final_Project
{
    partial class GuessLetter
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
            this.GuesslblLetters = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.GuesslblCurrentPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GuesslblLetters
            // 
            this.GuesslblLetters.AutoSize = true;
            this.GuesslblLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuesslblLetters.Location = new System.Drawing.Point(19, 49);
            this.GuesslblLetters.Name = "GuesslblLetters";
            this.GuesslblLetters.Size = new System.Drawing.Size(297, 18);
            this.GuesslblLetters.TabIndex = 10;
            this.GuesslblLetters.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // txtGuess
            // 
            this.txtGuess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess.Location = new System.Drawing.Point(132, 144);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(71, 24);
            this.txtGuess.TabIndex = 11;
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(116, 195);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(103, 34);
            this.btnGuess.TabIndex = 12;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            // 
            // GuesslblCurrentPlayer
            // 
            this.GuesslblCurrentPlayer.AutoSize = true;
            this.GuesslblCurrentPlayer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GuesslblCurrentPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuesslblCurrentPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuesslblCurrentPlayer.Location = new System.Drawing.Point(85, 94);
            this.GuesslblCurrentPlayer.Name = "GuesslblCurrentPlayer";
            this.GuesslblCurrentPlayer.Size = new System.Drawing.Size(173, 20);
            this.GuesslblCurrentPlayer.TabIndex = 13;
            this.GuesslblCurrentPlayer.Text = "Player 1 - Guess a Letter";
            this.GuesslblCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 254);
            this.Controls.Add(this.GuesslblCurrentPlayer);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.GuesslblLetters);
            this.Name = "GuessLetter";
            this.Text = "Guess a Letter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtGuess;
        public System.Windows.Forms.Label GuesslblLetters;
        public System.Windows.Forms.Label GuesslblCurrentPlayer;
        public System.Windows.Forms.Button btnGuess;
    }
}