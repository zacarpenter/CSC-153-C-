namespace Ch11Employee_And_ProductionWorker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radShiftSupervisor = new System.Windows.Forms.RadioButton();
            this.radProductionWorker = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmployeeNumber = new System.Windows.Forms.TextBox();
            this.comboBoxShift = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAnnualSalary = new System.Windows.Forms.TextBox();
            this.txtAnnualProductionBonus = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radProductionWorker);
            this.groupBox1.Controls.Add(this.radShiftSupervisor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // radShiftSupervisor
            // 
            this.radShiftSupervisor.AutoSize = true;
            this.radShiftSupervisor.Location = new System.Drawing.Point(25, 101);
            this.radShiftSupervisor.Name = "radShiftSupervisor";
            this.radShiftSupervisor.Size = new System.Drawing.Size(139, 24);
            this.radShiftSupervisor.TabIndex = 0;
            this.radShiftSupervisor.Text = "Shift Supervisor";
            this.radShiftSupervisor.UseVisualStyleBackColor = true;
            this.radShiftSupervisor.CheckedChanged += new System.EventHandler(this.radShiftSupervisor_CheckedChanged);
            // 
            // radProductionWorker
            // 
            this.radProductionWorker.AutoSize = true;
            this.radProductionWorker.Checked = true;
            this.radProductionWorker.Location = new System.Drawing.Point(25, 45);
            this.radProductionWorker.Name = "radProductionWorker";
            this.radProductionWorker.Size = new System.Drawing.Size(158, 24);
            this.radProductionWorker.TabIndex = 1;
            this.radProductionWorker.TabStop = true;
            this.radProductionWorker.Text = "Production Worker";
            this.radProductionWorker.UseVisualStyleBackColor = true;
            this.radProductionWorker.CheckedChanged += new System.EventHandler(this.radProductionWorker_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Number";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(259, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 26);
            this.txtName.TabIndex = 3;
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(259, 161);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.Size = new System.Drawing.Size(135, 26);
            this.txtEmployeeNumber.TabIndex = 4;
            // 
            // comboBoxShift
            // 
            this.comboBoxShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxShift.FormattingEnabled = true;
            this.comboBoxShift.Items.AddRange(new object[] {
            "Shift 1 (Day)",
            "Shift 2 (Night)"});
            this.comboBoxShift.Location = new System.Drawing.Point(30, 297);
            this.comboBoxShift.Name = "comboBoxShift";
            this.comboBoxShift.Size = new System.Drawing.Size(136, 28);
            this.comboBoxShift.TabIndex = 5;
            this.comboBoxShift.Text = "Choose Shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Production Worker Shift";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hourly Pay Rate";
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyPayRate.Location = new System.Drawing.Point(30, 408);
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(135, 26);
            this.txtHourlyPayRate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Annual Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Annual Production Bonus";
            // 
            // txtAnnualSalary
            // 
            this.txtAnnualSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualSalary.Location = new System.Drawing.Point(259, 297);
            this.txtAnnualSalary.Name = "txtAnnualSalary";
            this.txtAnnualSalary.Size = new System.Drawing.Size(135, 26);
            this.txtAnnualSalary.TabIndex = 11;
            // 
            // txtAnnualProductionBonus
            // 
            this.txtAnnualProductionBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnualProductionBonus.Location = new System.Drawing.Point(259, 408);
            this.txtAnnualProductionBonus.Name = "txtAnnualProductionBonus";
            this.txtAnnualProductionBonus.Size = new System.Drawing.Size(135, 26);
            this.txtAnnualProductionBonus.TabIndex = 12;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(31, 475);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(153, 43);
            this.btnCreate.TabIndex = 13;
            this.btnCreate.Text = "Create Employee";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(259, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 43);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 545);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAnnualProductionBonus);
            this.Controls.Add(this.txtAnnualSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHourlyPayRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxShift);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radProductionWorker;
        private System.Windows.Forms.RadioButton radShiftSupervisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmployeeNumber;
        private System.Windows.Forms.ComboBox comboBoxShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAnnualSalary;
        private System.Windows.Forms.TextBox txtAnnualProductionBonus;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnExit;
    }
}

