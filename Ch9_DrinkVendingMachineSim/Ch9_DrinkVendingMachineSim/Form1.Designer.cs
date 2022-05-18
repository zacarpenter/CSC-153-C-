namespace Ch9_DrinkVendingMachineSim
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cola = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgCola = new System.Windows.Forms.PictureBox();
            this.RootBeer = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imgRootBeer = new System.Windows.Forms.PictureBox();
            this.LemonLime = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imgLemonLime = new System.Windows.Forms.PictureBox();
            this.GrapeSoda = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imgGrapeSoda = new System.Windows.Forms.PictureBox();
            this.CreamSoda = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imgCreamSoda = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblColaRemaining = new System.Windows.Forms.Label();
            this.lblRootRemaining = new System.Windows.Forms.Label();
            this.lblLemonRemaining = new System.Windows.Forms.Label();
            this.lblGrapeRemaining = new System.Windows.Forms.Label();
            this.lblCreamRemaining = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Cola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).BeginInit();
            this.RootBeer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRootBeer)).BeginInit();
            this.LemonLime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLemonLime)).BeginInit();
            this.GrapeSoda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrapeSoda)).BeginInit();
            this.CreamSoda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCreamSoda)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Drink";
            // 
            // Cola
            // 
            this.Cola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cola.Controls.Add(this.lblColaRemaining);
            this.Cola.Controls.Add(this.label8);
            this.Cola.Controls.Add(this.label2);
            this.Cola.Controls.Add(this.imgCola);
            this.Cola.Location = new System.Drawing.Point(28, 91);
            this.Cola.Name = "Cola";
            this.Cola.Size = new System.Drawing.Size(274, 130);
            this.Cola.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(155, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Drinks Left:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "$1.00";
            // 
            // imgCola
            // 
            this.imgCola.Image = global::Ch9_DrinkVendingMachineSim.Properties.Resources.Cola;
            this.imgCola.Location = new System.Drawing.Point(20, 16);
            this.imgCola.Name = "imgCola";
            this.imgCola.Size = new System.Drawing.Size(93, 91);
            this.imgCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCola.TabIndex = 4;
            this.imgCola.TabStop = false;
            this.imgCola.Click += new System.EventHandler(this.imgCola_Click);
            // 
            // RootBeer
            // 
            this.RootBeer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RootBeer.Controls.Add(this.lblRootRemaining);
            this.RootBeer.Controls.Add(this.label9);
            this.RootBeer.Controls.Add(this.label3);
            this.RootBeer.Controls.Add(this.imgRootBeer);
            this.RootBeer.Location = new System.Drawing.Point(308, 91);
            this.RootBeer.Name = "RootBeer";
            this.RootBeer.Size = new System.Drawing.Size(274, 130);
            this.RootBeer.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(152, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Drinks Left:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "$1.00";
            // 
            // imgRootBeer
            // 
            this.imgRootBeer.Image = global::Ch9_DrinkVendingMachineSim.Properties.Resources.RootBeer;
            this.imgRootBeer.Location = new System.Drawing.Point(20, 16);
            this.imgRootBeer.Name = "imgRootBeer";
            this.imgRootBeer.Size = new System.Drawing.Size(93, 91);
            this.imgRootBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRootBeer.TabIndex = 4;
            this.imgRootBeer.TabStop = false;
            this.imgRootBeer.Click += new System.EventHandler(this.imgRootBeer_Click);
            // 
            // LemonLime
            // 
            this.LemonLime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LemonLime.Controls.Add(this.lblLemonRemaining);
            this.LemonLime.Controls.Add(this.label10);
            this.LemonLime.Controls.Add(this.label4);
            this.LemonLime.Controls.Add(this.imgLemonLime);
            this.LemonLime.Location = new System.Drawing.Point(28, 227);
            this.LemonLime.Name = "LemonLime";
            this.LemonLime.Size = new System.Drawing.Size(274, 130);
            this.LemonLime.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(155, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Drinks Left:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "$1.00";
            // 
            // imgLemonLime
            // 
            this.imgLemonLime.Image = global::Ch9_DrinkVendingMachineSim.Properties.Resources.LemonLime;
            this.imgLemonLime.Location = new System.Drawing.Point(20, 16);
            this.imgLemonLime.Name = "imgLemonLime";
            this.imgLemonLime.Size = new System.Drawing.Size(93, 91);
            this.imgLemonLime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLemonLime.TabIndex = 4;
            this.imgLemonLime.TabStop = false;
            this.imgLemonLime.Click += new System.EventHandler(this.imgLemonLime_Click);
            // 
            // GrapeSoda
            // 
            this.GrapeSoda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GrapeSoda.Controls.Add(this.lblGrapeRemaining);
            this.GrapeSoda.Controls.Add(this.label11);
            this.GrapeSoda.Controls.Add(this.label5);
            this.GrapeSoda.Controls.Add(this.imgGrapeSoda);
            this.GrapeSoda.Location = new System.Drawing.Point(308, 227);
            this.GrapeSoda.Name = "GrapeSoda";
            this.GrapeSoda.Size = new System.Drawing.Size(274, 130);
            this.GrapeSoda.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(152, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Drinks Left:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "$1.50";
            // 
            // imgGrapeSoda
            // 
            this.imgGrapeSoda.Image = global::Ch9_DrinkVendingMachineSim.Properties.Resources.GrapeSoda;
            this.imgGrapeSoda.Location = new System.Drawing.Point(20, 16);
            this.imgGrapeSoda.Name = "imgGrapeSoda";
            this.imgGrapeSoda.Size = new System.Drawing.Size(93, 91);
            this.imgGrapeSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGrapeSoda.TabIndex = 4;
            this.imgGrapeSoda.TabStop = false;
            this.imgGrapeSoda.Click += new System.EventHandler(this.imgGrapeSoda_Click);
            // 
            // CreamSoda
            // 
            this.CreamSoda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CreamSoda.Controls.Add(this.lblCreamRemaining);
            this.CreamSoda.Controls.Add(this.label12);
            this.CreamSoda.Controls.Add(this.label6);
            this.CreamSoda.Controls.Add(this.imgCreamSoda);
            this.CreamSoda.Location = new System.Drawing.Point(28, 363);
            this.CreamSoda.Name = "CreamSoda";
            this.CreamSoda.Size = new System.Drawing.Size(274, 130);
            this.CreamSoda.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(155, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Drinks Left:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "$1.50";
            // 
            // imgCreamSoda
            // 
            this.imgCreamSoda.Image = global::Ch9_DrinkVendingMachineSim.Properties.Resources.CreamSoda;
            this.imgCreamSoda.Location = new System.Drawing.Point(20, 16);
            this.imgCreamSoda.Name = "imgCreamSoda";
            this.imgCreamSoda.Size = new System.Drawing.Size(93, 91);
            this.imgCreamSoda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCreamSoda.TabIndex = 4;
            this.imgCreamSoda.TabStop = false;
            this.imgCreamSoda.Click += new System.EventHandler(this.imgCreamSoda_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblTotal);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(308, 363);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 130);
            this.panel6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Sales";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(253, 518);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 42);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblColaRemaining
            // 
            this.lblColaRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblColaRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaRemaining.Location = new System.Drawing.Point(177, 81);
            this.lblColaRemaining.Name = "lblColaRemaining";
            this.lblColaRemaining.Size = new System.Drawing.Size(50, 27);
            this.lblColaRemaining.TabIndex = 8;
            this.lblColaRemaining.Text = "20";
            this.lblColaRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRootRemaining
            // 
            this.lblRootRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRootRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRootRemaining.Location = new System.Drawing.Point(173, 81);
            this.lblRootRemaining.Name = "lblRootRemaining";
            this.lblRootRemaining.Size = new System.Drawing.Size(50, 27);
            this.lblRootRemaining.TabIndex = 9;
            this.lblRootRemaining.Text = "20";
            this.lblRootRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLemonRemaining
            // 
            this.lblLemonRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLemonRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLemonRemaining.Location = new System.Drawing.Point(177, 80);
            this.lblLemonRemaining.Name = "lblLemonRemaining";
            this.lblLemonRemaining.Size = new System.Drawing.Size(50, 27);
            this.lblLemonRemaining.TabIndex = 10;
            this.lblLemonRemaining.Text = "20";
            this.lblLemonRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrapeRemaining
            // 
            this.lblGrapeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrapeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrapeRemaining.Location = new System.Drawing.Point(173, 80);
            this.lblGrapeRemaining.Name = "lblGrapeRemaining";
            this.lblGrapeRemaining.Size = new System.Drawing.Size(50, 27);
            this.lblGrapeRemaining.TabIndex = 9;
            this.lblGrapeRemaining.Text = "20";
            this.lblGrapeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCreamRemaining
            // 
            this.lblCreamRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreamRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreamRemaining.Location = new System.Drawing.Point(177, 80);
            this.lblCreamRemaining.Name = "lblCreamRemaining";
            this.lblCreamRemaining.Size = new System.Drawing.Size(50, 27);
            this.lblCreamRemaining.TabIndex = 9;
            this.lblCreamRemaining.Text = "20";
            this.lblCreamRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(82, 85);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(115, 22);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 593);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.CreamSoda);
            this.Controls.Add(this.GrapeSoda);
            this.Controls.Add(this.LemonLime);
            this.Controls.Add(this.RootBeer);
            this.Controls.Add(this.Cola);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Drink Machine";
            this.Cola.ResumeLayout(false);
            this.Cola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCola)).EndInit();
            this.RootBeer.ResumeLayout(false);
            this.RootBeer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRootBeer)).EndInit();
            this.LemonLime.ResumeLayout(false);
            this.LemonLime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLemonLime)).EndInit();
            this.GrapeSoda.ResumeLayout(false);
            this.GrapeSoda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrapeSoda)).EndInit();
            this.CreamSoda.ResumeLayout(false);
            this.CreamSoda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCreamSoda)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgCola;
        private System.Windows.Forms.Panel Cola;
        private System.Windows.Forms.Panel RootBeer;
        private System.Windows.Forms.PictureBox imgRootBeer;
        private System.Windows.Forms.Panel LemonLime;
        private System.Windows.Forms.PictureBox imgLemonLime;
        private System.Windows.Forms.Panel GrapeSoda;
        private System.Windows.Forms.PictureBox imgGrapeSoda;
        private System.Windows.Forms.Panel CreamSoda;
        private System.Windows.Forms.PictureBox imgCreamSoda;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblColaRemaining;
        private System.Windows.Forms.Label lblRootRemaining;
        private System.Windows.Forms.Label lblLemonRemaining;
        private System.Windows.Forms.Label lblGrapeRemaining;
        private System.Windows.Forms.Label lblCreamRemaining;
        private System.Windows.Forms.Label lblTotal;
    }
}

