namespace Ch7_TotalSales
{
    partial class TotalSales
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
            this.ouputBox = new System.Windows.Forms.ListBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.averageTxt = new System.Windows.Forms.TextBox();
            this.highestTxt = new System.Windows.Forms.TextBox();
            this.lowestTxt = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.averageLbl = new System.Windows.Forms.Label();
            this.highestLbl = new System.Windows.Forms.Label();
            this.lowestLbl = new System.Windows.Forms.Label();
            this.Sales = new System.Windows.Forms.GroupBox();
            this.Sales.SuspendLayout();
            this.SuspendLayout();
            // 
            // ouputBox
            // 
            this.ouputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouputBox.FormattingEnabled = true;
            this.ouputBox.ItemHeight = 20;
            this.ouputBox.Location = new System.Drawing.Point(30, 37);
            this.ouputBox.Name = "ouputBox";
            this.ouputBox.Size = new System.Drawing.Size(107, 184);
            this.ouputBox.TabIndex = 0;
            // 
            // displayBtn
            // 
            this.displayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.Location = new System.Drawing.Point(30, 243);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(107, 84);
            this.displayBtn.TabIndex = 1;
            this.displayBtn.Text = "Display and Calculate";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(153, 37);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(145, 24);
            this.totalTxt.TabIndex = 2;
            // 
            // averageTxt
            // 
            this.averageTxt.Location = new System.Drawing.Point(153, 104);
            this.averageTxt.Name = "averageTxt";
            this.averageTxt.Size = new System.Drawing.Size(145, 24);
            this.averageTxt.TabIndex = 3;
            // 
            // highestTxt
            // 
            this.highestTxt.Location = new System.Drawing.Point(153, 173);
            this.highestTxt.Name = "highestTxt";
            this.highestTxt.Size = new System.Drawing.Size(145, 24);
            this.highestTxt.TabIndex = 4;
            // 
            // lowestTxt
            // 
            this.lowestTxt.Location = new System.Drawing.Point(153, 248);
            this.lowestTxt.Name = "lowestTxt";
            this.lowestTxt.Size = new System.Drawing.Size(145, 24);
            this.lowestTxt.TabIndex = 5;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(100, 39);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(45, 18);
            this.totalLbl.TabIndex = 6;
            this.totalLbl.Text = "Total:";
            // 
            // averageLbl
            // 
            this.averageLbl.AutoSize = true;
            this.averageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLbl.Location = new System.Drawing.Point(80, 106);
            this.averageLbl.Name = "averageLbl";
            this.averageLbl.Size = new System.Drawing.Size(65, 18);
            this.averageLbl.TabIndex = 7;
            this.averageLbl.Text = "Average:";
            // 
            // highestLbl
            // 
            this.highestLbl.AutoSize = true;
            this.highestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestLbl.Location = new System.Drawing.Point(52, 175);
            this.highestLbl.Name = "highestLbl";
            this.highestLbl.Size = new System.Drawing.Size(95, 18);
            this.highestLbl.TabIndex = 8;
            this.highestLbl.Text = "Highest Sale:";
            // 
            // lowestLbl
            // 
            this.lowestLbl.AutoSize = true;
            this.lowestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowestLbl.Location = new System.Drawing.Point(54, 250);
            this.lowestLbl.Name = "lowestLbl";
            this.lowestLbl.Size = new System.Drawing.Size(93, 18);
            this.lowestLbl.TabIndex = 10;
            this.lowestLbl.Text = "Lowest Sale:";
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.lowestLbl);
            this.Sales.Controls.Add(this.highestLbl);
            this.Sales.Controls.Add(this.averageLbl);
            this.Sales.Controls.Add(this.totalLbl);
            this.Sales.Controls.Add(this.lowestTxt);
            this.Sales.Controls.Add(this.highestTxt);
            this.Sales.Controls.Add(this.averageTxt);
            this.Sales.Controls.Add(this.totalTxt);
            this.Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(167, 24);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(343, 303);
            this.Sales.TabIndex = 11;
            this.Sales.TabStop = false;
            this.Sales.Text = "Sales";
            // 
            // TotalSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 352);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.ouputBox);
            this.Name = "TotalSales";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Total Sales";
            this.Sales.ResumeLayout(false);
            this.Sales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ouputBox;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.TextBox averageTxt;
        private System.Windows.Forms.TextBox highestTxt;
        private System.Windows.Forms.TextBox lowestTxt;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label averageLbl;
        private System.Windows.Forms.Label highestLbl;
        private System.Windows.Forms.Label lowestLbl;
        private System.Windows.Forms.GroupBox Sales;
    }
}

