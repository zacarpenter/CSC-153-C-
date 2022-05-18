namespace RockPaperScissors
{
    partial class RockPaperScissors
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
            this.UserChoiceBox = new System.Windows.Forms.GroupBox();
            this.userChoiceImage = new System.Windows.Forms.PictureBox();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.rockBtn = new System.Windows.Forms.Button();
            this.computerChoiceImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userWinsLbl = new System.Windows.Forms.Label();
            this.drawLbl = new System.Windows.Forms.Label();
            this.compWinsLbl = new System.Windows.Forms.Label();
            this.userWinsTxtBox = new System.Windows.Forms.TextBox();
            this.computerWinsTxtBox = new System.Windows.Forms.TextBox();
            this.drawsTxtBox = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.UserChoiceBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userChoiceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoiceImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserChoiceBox
            // 
            this.UserChoiceBox.Controls.Add(this.userChoiceImage);
            this.UserChoiceBox.Controls.Add(this.scissorsBtn);
            this.UserChoiceBox.Controls.Add(this.paperBtn);
            this.UserChoiceBox.Controls.Add(this.rockBtn);
            this.UserChoiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserChoiceBox.Location = new System.Drawing.Point(12, 12);
            this.UserChoiceBox.Name = "UserChoiceBox";
            this.UserChoiceBox.Size = new System.Drawing.Size(299, 184);
            this.UserChoiceBox.TabIndex = 0;
            this.UserChoiceBox.TabStop = false;
            this.UserChoiceBox.Text = "USER\'s Choice";
            // 
            // userChoiceImage
            // 
            this.userChoiceImage.Location = new System.Drawing.Point(155, 45);
            this.userChoiceImage.Name = "userChoiceImage";
            this.userChoiceImage.Size = new System.Drawing.Size(122, 116);
            this.userChoiceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userChoiceImage.TabIndex = 3;
            this.userChoiceImage.TabStop = false;
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.Location = new System.Drawing.Point(23, 127);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(94, 35);
            this.scissorsBtn.TabIndex = 2;
            this.scissorsBtn.Text = "Scissors";
            this.scissorsBtn.UseVisualStyleBackColor = true;
            this.scissorsBtn.Click += new System.EventHandler(this.scissorsBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.Location = new System.Drawing.Point(23, 86);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(94, 35);
            this.paperBtn.TabIndex = 1;
            this.paperBtn.Text = "Paper";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // rockBtn
            // 
            this.rockBtn.Location = new System.Drawing.Point(23, 45);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(94, 35);
            this.rockBtn.TabIndex = 0;
            this.rockBtn.Text = "Rock";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // computerChoiceImage
            // 
            this.computerChoiceImage.Location = new System.Drawing.Point(29, 45);
            this.computerChoiceImage.Name = "computerChoiceImage";
            this.computerChoiceImage.Size = new System.Drawing.Size(122, 116);
            this.computerChoiceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerChoiceImage.TabIndex = 4;
            this.computerChoiceImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.computerChoiceImage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(339, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 184);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPUTER\'s Choice";
            // 
            // userWinsLbl
            // 
            this.userWinsLbl.AutoSize = true;
            this.userWinsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWinsLbl.Location = new System.Drawing.Point(52, 68);
            this.userWinsLbl.Name = "userWinsLbl";
            this.userWinsLbl.Size = new System.Drawing.Size(168, 20);
            this.userWinsLbl.TabIndex = 6;
            this.userWinsLbl.Text = "Games won by USER:";
            // 
            // drawLbl
            // 
            this.drawLbl.AutoSize = true;
            this.drawLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLbl.Location = new System.Drawing.Point(77, 128);
            this.drawLbl.Name = "drawLbl";
            this.drawLbl.Size = new System.Drawing.Size(143, 20);
            this.drawLbl.TabIndex = 7;
            this.drawLbl.Text = "Games undecided:";
            // 
            // compWinsLbl
            // 
            this.compWinsLbl.AutoSize = true;
            this.compWinsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compWinsLbl.Location = new System.Drawing.Point(8, 100);
            this.compWinsLbl.Name = "compWinsLbl";
            this.compWinsLbl.Size = new System.Drawing.Size(212, 20);
            this.compWinsLbl.TabIndex = 8;
            this.compWinsLbl.Text = "Games won by COMPUTER:";
            // 
            // userWinsTxtBox
            // 
            this.userWinsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userWinsTxtBox.Location = new System.Drawing.Point(226, 66);
            this.userWinsTxtBox.Name = "userWinsTxtBox";
            this.userWinsTxtBox.Size = new System.Drawing.Size(93, 22);
            this.userWinsTxtBox.TabIndex = 9;
            this.userWinsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // computerWinsTxtBox
            // 
            this.computerWinsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerWinsTxtBox.Location = new System.Drawing.Point(226, 98);
            this.computerWinsTxtBox.Name = "computerWinsTxtBox";
            this.computerWinsTxtBox.Size = new System.Drawing.Size(93, 22);
            this.computerWinsTxtBox.TabIndex = 10;
            this.computerWinsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drawsTxtBox
            // 
            this.drawsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawsTxtBox.Location = new System.Drawing.Point(226, 128);
            this.drawsTxtBox.Name = "drawsTxtBox";
            this.drawsTxtBox.Size = new System.Drawing.Size(93, 22);
            this.drawsTxtBox.TabIndex = 11;
            this.drawsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(384, 272);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(106, 34);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.resultTxtBox);
            this.resultsGroupBox.Controls.Add(this.userWinsLbl);
            this.resultsGroupBox.Controls.Add(this.compWinsLbl);
            this.resultsGroupBox.Controls.Add(this.drawsTxtBox);
            this.resultsGroupBox.Controls.Add(this.drawLbl);
            this.resultsGroupBox.Controls.Add(this.computerWinsTxtBox);
            this.resultsGroupBox.Controls.Add(this.userWinsTxtBox);
            this.resultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 202);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(325, 166);
            this.resultsGroupBox.TabIndex = 14;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxtBox.Location = new System.Drawing.Point(12, 38);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.Size = new System.Drawing.Size(307, 22);
            this.resultTxtBox.TabIndex = 12;
            this.resultTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 380);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserChoiceBox);
            this.Name = "RockPaperScissors";
            this.Text = "Rock, Paper, Scissors";
            this.UserChoiceBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userChoiceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerChoiceImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserChoiceBox;
        private System.Windows.Forms.PictureBox userChoiceImage;
        private System.Windows.Forms.Button scissorsBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.PictureBox computerChoiceImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label userWinsLbl;
        private System.Windows.Forms.Label drawLbl;
        private System.Windows.Forms.Label compWinsLbl;
        private System.Windows.Forms.TextBox userWinsTxtBox;
        private System.Windows.Forms.TextBox computerWinsTxtBox;
        private System.Windows.Forms.TextBox drawsTxtBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox resultTxtBox;
    }
}

