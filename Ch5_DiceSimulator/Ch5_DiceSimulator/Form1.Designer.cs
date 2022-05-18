namespace Ch5_DiceSimulator
{
    partial class diceSimulator
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
            this.btnRollDice = new System.Windows.Forms.Button();
            this.userDice2Pic = new System.Windows.Forms.PictureBox();
            this.userDice1Pic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.compDice2Pic = new System.Windows.Forms.PictureBox();
            this.compDice1Pic = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDice2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDice1Pic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compDice2Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDice1Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(156, 37);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(130, 35);
            this.btnRollDice.TabIndex = 0;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // userDice2Pic
            // 
            this.userDice2Pic.Location = new System.Drawing.Point(238, 23);
            this.userDice2Pic.Name = "userDice2Pic";
            this.userDice2Pic.Size = new System.Drawing.Size(150, 150);
            this.userDice2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDice2Pic.TabIndex = 2;
            this.userDice2Pic.TabStop = false;
            // 
            // userDice1Pic
            // 
            this.userDice1Pic.Location = new System.Drawing.Point(9, 23);
            this.userDice1Pic.Name = "userDice1Pic";
            this.userDice1Pic.Size = new System.Drawing.Size(150, 150);
            this.userDice1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userDice1Pic.TabIndex = 1;
            this.userDice1Pic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.userDice2Pic);
            this.groupBox1.Controls.Add(this.userDice1Pic);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 197);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Roll";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.compDice2Pic);
            this.groupBox2.Controls.Add(this.compDice1Pic);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 182);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Computer Roll";
            // 
            // compDice2Pic
            // 
            this.compDice2Pic.Location = new System.Drawing.Point(238, 19);
            this.compDice2Pic.Name = "compDice2Pic";
            this.compDice2Pic.Size = new System.Drawing.Size(150, 150);
            this.compDice2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compDice2Pic.TabIndex = 3;
            this.compDice2Pic.TabStop = false;
            // 
            // compDice1Pic
            // 
            this.compDice1Pic.Location = new System.Drawing.Point(9, 19);
            this.compDice1Pic.Name = "compDice1Pic";
            this.compDice1Pic.Size = new System.Drawing.Size(150, 150);
            this.compDice1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.compDice1Pic.TabIndex = 2;
            this.compDice1Pic.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(156, 543);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 44);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // diceSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 611);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRollDice);
            this.Name = "diceSimulator";
            this.Text = "Dice Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.userDice2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDice1Pic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.compDice2Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDice1Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox userDice1Pic;
        private System.Windows.Forms.PictureBox userDice2Pic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox compDice2Pic;
        private System.Windows.Forms.PictureBox compDice1Pic;
        private System.Windows.Forms.Button btnExit;
    }
}

