namespace ch2CardIdentifier
{
    partial class frmCardIdentifier
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
            this.identifierLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.kingClubs = new System.Windows.Forms.PictureBox();
            this.jackDiamonds = new System.Windows.Forms.PictureBox();
            this.queenHearts = new System.Windows.Forms.PictureBox();
            this.aceSpades = new System.Windows.Forms.PictureBox();
            this.twoClubs = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kingClubs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackDiamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // identifierLabel
            // 
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Location = new System.Drawing.Point(187, 347);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(0, 13);
            this.identifierLabel.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Control;
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(158, 323);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(387, 37);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kingClubs
            // 
            this.kingClubs.Image = global::ch2CardIdentifier.Properties.Resources.King_Clubs;
            this.kingClubs.Location = new System.Drawing.Point(571, 127);
            this.kingClubs.Name = "kingClubs";
            this.kingClubs.Size = new System.Drawing.Size(110, 160);
            this.kingClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingClubs.TabIndex = 6;
            this.kingClubs.TabStop = false;
            this.kingClubs.Click += new System.EventHandler(this.kingClubs_Click);
            // 
            // jackDiamonds
            // 
            this.jackDiamonds.Image = global::ch2CardIdentifier.Properties.Resources.Jack_Diamonds;
            this.jackDiamonds.Location = new System.Drawing.Point(435, 127);
            this.jackDiamonds.Name = "jackDiamonds";
            this.jackDiamonds.Size = new System.Drawing.Size(110, 160);
            this.jackDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jackDiamonds.TabIndex = 5;
            this.jackDiamonds.TabStop = false;
            this.jackDiamonds.Click += new System.EventHandler(this.jackDiamonds_Click);
            // 
            // queenHearts
            // 
            this.queenHearts.Image = global::ch2CardIdentifier.Properties.Resources.Queen_Hearts;
            this.queenHearts.Location = new System.Drawing.Point(293, 127);
            this.queenHearts.Name = "queenHearts";
            this.queenHearts.Size = new System.Drawing.Size(110, 160);
            this.queenHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.queenHearts.TabIndex = 4;
            this.queenHearts.TabStop = false;
            this.queenHearts.Click += new System.EventHandler(this.queenHearts_Click);
            // 
            // aceSpades
            // 
            this.aceSpades.Image = global::ch2CardIdentifier.Properties.Resources.Ace_Spades;
            this.aceSpades.Location = new System.Drawing.Point(158, 127);
            this.aceSpades.Name = "aceSpades";
            this.aceSpades.Size = new System.Drawing.Size(110, 160);
            this.aceSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceSpades.TabIndex = 3;
            this.aceSpades.TabStop = false;
            this.aceSpades.Click += new System.EventHandler(this.aceSpades_Click);
            // 
            // twoClubs
            // 
            this.twoClubs.Image = global::ch2CardIdentifier.Properties.Resources._2_Clubs;
            this.twoClubs.Location = new System.Drawing.Point(26, 127);
            this.twoClubs.Name = "twoClubs";
            this.twoClubs.Size = new System.Drawing.Size(110, 160);
            this.twoClubs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.twoClubs.TabIndex = 0;
            this.twoClubs.TabStop = false;
            this.twoClubs.Click += new System.EventHandler(this.twoClubs_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(166, 42);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(379, 53);
            this.questionLabel.TabIndex = 7;
            this.questionLabel.Text = "Click a Card to See Its Name";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCardIdentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 388);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.kingClubs);
            this.Controls.Add(this.jackDiamonds);
            this.Controls.Add(this.queenHearts);
            this.Controls.Add(this.aceSpades);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.identifierLabel);
            this.Controls.Add(this.twoClubs);
            this.Name = "frmCardIdentifier";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.kingClubs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jackDiamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queenHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoClubs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox twoClubs;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox aceSpades;
        private System.Windows.Forms.PictureBox queenHearts;
        private System.Windows.Forms.PictureBox jackDiamonds;
        private System.Windows.Forms.PictureBox kingClubs;
        private System.Windows.Forms.Label questionLabel;
    }
}

