namespace Ch4_DistanceConverter
{
    partial class distanceConverter
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
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.listFrom = new System.Windows.Forms.ListBox();
            this.convertFromBox = new System.Windows.Forms.GroupBox();
            this.convertToBox = new System.Windows.Forms.GroupBox();
            this.listTo = new System.Windows.Forms.ListBox();
            this.lblConvertedDistance = new System.Windows.Forms.Label();
            this.txtConvertedDistance = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.convertFromBox.SuspendLayout();
            this.convertToBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(16, 21);
            this.lblDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(168, 16);
            this.lblDistance.TabIndex = 0;
            this.lblDistance.Text = "Enter a distance to convert:";
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(192, 21);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(165, 22);
            this.txtDistance.TabIndex = 1;
            // 
            // listFrom
            // 
            this.listFrom.BackColor = System.Drawing.SystemColors.Window;
            this.listFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFrom.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listFrom.FormattingEnabled = true;
            this.listFrom.ItemHeight = 16;
            this.listFrom.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.listFrom.Location = new System.Drawing.Point(18, 46);
            this.listFrom.Margin = new System.Windows.Forms.Padding(4);
            this.listFrom.Name = "listFrom";
            this.listFrom.Size = new System.Drawing.Size(127, 52);
            this.listFrom.TabIndex = 2;
            this.listFrom.Tag = "";
            // 
            // convertFromBox
            // 
            this.convertFromBox.Controls.Add(this.listFrom);
            this.convertFromBox.Location = new System.Drawing.Point(13, 64);
            this.convertFromBox.Margin = new System.Windows.Forms.Padding(4);
            this.convertFromBox.Name = "convertFromBox";
            this.convertFromBox.Padding = new System.Windows.Forms.Padding(4);
            this.convertFromBox.Size = new System.Drawing.Size(165, 142);
            this.convertFromBox.TabIndex = 3;
            this.convertFromBox.TabStop = false;
            this.convertFromBox.Text = "From";
            // 
            // convertToBox
            // 
            this.convertToBox.Controls.Add(this.listTo);
            this.convertToBox.Location = new System.Drawing.Point(192, 64);
            this.convertToBox.Name = "convertToBox";
            this.convertToBox.Size = new System.Drawing.Size(165, 142);
            this.convertToBox.TabIndex = 4;
            this.convertToBox.TabStop = false;
            this.convertToBox.Text = "To";
            // 
            // listTo
            // 
            this.listTo.FormattingEnabled = true;
            this.listTo.ItemHeight = 16;
            this.listTo.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.listTo.Location = new System.Drawing.Point(15, 46);
            this.listTo.Name = "listTo";
            this.listTo.Size = new System.Drawing.Size(128, 52);
            this.listTo.TabIndex = 0;
            // 
            // lblConvertedDistance
            // 
            this.lblConvertedDistance.AutoSize = true;
            this.lblConvertedDistance.BackColor = System.Drawing.SystemColors.Control;
            this.lblConvertedDistance.Location = new System.Drawing.Point(49, 229);
            this.lblConvertedDistance.Name = "lblConvertedDistance";
            this.lblConvertedDistance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConvertedDistance.Size = new System.Drawing.Size(129, 16);
            this.lblConvertedDistance.TabIndex = 5;
            this.lblConvertedDistance.Text = "Converted Distance:";
            // 
            // txtConvertedDistance
            // 
            this.txtConvertedDistance.Location = new System.Drawing.Point(192, 226);
            this.txtConvertedDistance.Name = "txtConvertedDistance";
            this.txtConvertedDistance.Size = new System.Drawing.Size(146, 22);
            this.txtConvertedDistance.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(69, 270);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(109, 30);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(192, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // distanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConvertedDistance);
            this.Controls.Add(this.lblConvertedDistance);
            this.Controls.Add(this.convertToBox);
            this.Controls.Add(this.convertFromBox);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "distanceConverter";
            this.Text = "Distance Converter";
            this.convertFromBox.ResumeLayout(false);
            this.convertToBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.ListBox listFrom;
        private System.Windows.Forms.GroupBox convertFromBox;
        private System.Windows.Forms.GroupBox convertToBox;
        private System.Windows.Forms.ListBox listTo;
        private System.Windows.Forms.Label lblConvertedDistance;
        private System.Windows.Forms.TextBox txtConvertedDistance;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
    }
}

