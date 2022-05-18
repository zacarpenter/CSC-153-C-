namespace ch3CalorieCounter
{
    partial class calorieCounter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.appleImage = new System.Windows.Forms.PictureBox();
            this.bananaImage = new System.Windows.Forms.PictureBox();
            this.orangeImage = new System.Windows.Forms.PictureBox();
            this.pearImage = new System.Windows.Forms.PictureBox();
            this.caloriesLbl = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.appleImage);
            this.panel1.Controls.Add(this.bananaImage);
            this.panel1.Controls.Add(this.orangeImage);
            this.panel1.Controls.Add(this.pearImage);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 353);
            this.panel1.TabIndex = 1;
            // 
            // appleImage
            // 
            this.appleImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.appleImage.Image = global::ch3CalorieCounter.Properties.Resources.AppleCalories;
            this.appleImage.Location = new System.Drawing.Point(175, 185);
            this.appleImage.Name = "appleImage";
            this.appleImage.Size = new System.Drawing.Size(130, 157);
            this.appleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.appleImage.TabIndex = 3;
            this.appleImage.TabStop = false;
            this.appleImage.Click += new System.EventHandler(this.appleImage_Click);
            // 
            // bananaImage
            // 
            this.bananaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bananaImage.Image = global::ch3CalorieCounter.Properties.Resources.BananaCalories;
            this.bananaImage.Location = new System.Drawing.Point(18, 185);
            this.bananaImage.Name = "bananaImage";
            this.bananaImage.Size = new System.Drawing.Size(130, 157);
            this.bananaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bananaImage.TabIndex = 2;
            this.bananaImage.TabStop = false;
            this.bananaImage.Click += new System.EventHandler(this.bananaImage_Click);
            // 
            // orangeImage
            // 
            this.orangeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangeImage.Image = global::ch3CalorieCounter.Properties.Resources.OrangeCalories;
            this.orangeImage.Location = new System.Drawing.Point(175, 11);
            this.orangeImage.Name = "orangeImage";
            this.orangeImage.Size = new System.Drawing.Size(130, 157);
            this.orangeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orangeImage.TabIndex = 1;
            this.orangeImage.TabStop = false;
            this.orangeImage.Click += new System.EventHandler(this.orangeImage_Click);
            // 
            // pearImage
            // 
            this.pearImage.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.pearImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pearImage.Image = global::ch3CalorieCounter.Properties.Resources.PearCalories;
            this.pearImage.InitialImage = global::ch3CalorieCounter.Properties.Resources.Pear;
            this.pearImage.Location = new System.Drawing.Point(18, 11);
            this.pearImage.Name = "pearImage";
            this.pearImage.Size = new System.Drawing.Size(130, 157);
            this.pearImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pearImage.TabIndex = 0;
            this.pearImage.TabStop = false;
            this.pearImage.Tag = "";
            this.pearImage.Click += new System.EventHandler(this.pearImage_Click);
            // 
            // caloriesLbl
            // 
            this.caloriesLbl.AutoSize = true;
            this.caloriesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesLbl.Location = new System.Drawing.Point(359, 12);
            this.caloriesLbl.Name = "caloriesLbl";
            this.caloriesLbl.Size = new System.Drawing.Size(119, 20);
            this.caloriesLbl.TabIndex = 2;
            this.caloriesLbl.Text = "Total Calories";
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.SystemColors.Control;
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(357, 38);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(129, 26);
            this.totalLabel.TabIndex = 3;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(363, 258);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(105, 35);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(363, 312);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 35);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // calorieCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 381);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.caloriesLbl);
            this.Controls.Add(this.panel1);
            this.Name = "calorieCounter";
            this.Text = "Calorie Counter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pearImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox orangeImage;
        private System.Windows.Forms.PictureBox bananaImage;
        private System.Windows.Forms.PictureBox appleImage;
        private System.Windows.Forms.Label caloriesLbl;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox totalLabel;
    }
}

