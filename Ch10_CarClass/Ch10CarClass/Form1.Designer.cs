namespace Ch10CarClass
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
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnSecondPage = new System.Windows.Forms.Button();
            this.lblCurrentSpeed = new System.Windows.Forms.Label();
            this.txtCurrentSpeed = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccelerate.Location = new System.Drawing.Point(36, 28);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(134, 48);
            this.btnAccelerate.TabIndex = 0;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrake.Location = new System.Drawing.Point(36, 114);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(134, 48);
            this.btnBrake.TabIndex = 1;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnSecondPage
            // 
            this.btnSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondPage.Location = new System.Drawing.Point(246, 303);
            this.btnSecondPage.Name = "btnSecondPage";
            this.btnSecondPage.Size = new System.Drawing.Size(134, 48);
            this.btnSecondPage.TabIndex = 2;
            this.btnSecondPage.Text = "View Car Info";
            this.btnSecondPage.UseVisualStyleBackColor = true;
            this.btnSecondPage.Click += new System.EventHandler(this.btnSecondPage_Click);
            // 
            // lblCurrentSpeed
            // 
            this.lblCurrentSpeed.AutoSize = true;
            this.lblCurrentSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSpeed.Location = new System.Drawing.Point(241, 39);
            this.lblCurrentSpeed.Name = "lblCurrentSpeed";
            this.lblCurrentSpeed.Size = new System.Drawing.Size(151, 25);
            this.lblCurrentSpeed.TabIndex = 3;
            this.lblCurrentSpeed.Text = "Current Speed";
            // 
            // txtCurrentSpeed
            // 
            this.txtCurrentSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentSpeed.Location = new System.Drawing.Point(242, 115);
            this.txtCurrentSpeed.Name = "txtCurrentSpeed";
            this.txtCurrentSpeed.Size = new System.Drawing.Size(150, 47);
            this.txtCurrentSpeed.TabIndex = 4;
            this.txtCurrentSpeed.Text = "0";
            this.txtCurrentSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(36, 283);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(133, 20);
            this.txtYear.TabIndex = 5;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(36, 391);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(133, 20);
            this.txtMake.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Car Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter Car Make:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCurrentSpeed);
            this.Controls.Add(this.lblCurrentSpeed);
            this.Controls.Add(this.btnSecondPage);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAccelerate);
            this.Name = "Form1";
            this.Text = "Car Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnSecondPage;
        private System.Windows.Forms.Label lblCurrentSpeed;
        private System.Windows.Forms.TextBox txtCurrentSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtMake;
    }
}

