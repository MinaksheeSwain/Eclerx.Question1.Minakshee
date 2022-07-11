namespace Eclerx.Question1.Minakshee
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
            this.lblEmployeeNo = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.TxtEmployeeNo = new System.Windows.Forms.TextBox();
            this.TxtEmployeeName = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpEmployeeType = new System.Windows.Forms.GroupBox();
            this.radioConsultant = new System.Windows.Forms.RadioButton();
            this.radioPayroll = new System.Windows.Forms.RadioButton();
            this.grpEmployeeType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmployeeNo
            // 
            this.lblEmployeeNo.AutoSize = true;
            this.lblEmployeeNo.Location = new System.Drawing.Point(125, 110);
            this.lblEmployeeNo.Name = "lblEmployeeNo";
            this.lblEmployeeNo.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeNo.TabIndex = 0;
            this.lblEmployeeNo.Text = "Employee No";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(125, 167);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(81, 13);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "EmployeeName";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(125, 213);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 2;
            this.lblSalary.Text = "Salary";
            // 
            // TxtEmployeeNo
            // 
            this.TxtEmployeeNo.Location = new System.Drawing.Point(224, 110);
            this.TxtEmployeeNo.Name = "TxtEmployeeNo";
            this.TxtEmployeeNo.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeNo.TabIndex = 3;
            // 
            // TxtEmployeeName
            // 
            this.TxtEmployeeName.Location = new System.Drawing.Point(224, 167);
            this.TxtEmployeeName.Name = "TxtEmployeeName";
            this.TxtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.TxtEmployeeName.TabIndex = 4;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Location = new System.Drawing.Point(224, 210);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(100, 20);
            this.TxtSalary.TabIndex = 5;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(133, 342);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(312, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpEmployeeType
            // 
            this.grpEmployeeType.Controls.Add(this.radioPayroll);
            this.grpEmployeeType.Controls.Add(this.radioConsultant);
            this.grpEmployeeType.Location = new System.Drawing.Point(555, 178);
            this.grpEmployeeType.Name = "grpEmployeeType";
            this.grpEmployeeType.Size = new System.Drawing.Size(126, 100);
            this.grpEmployeeType.TabIndex = 11;
            this.grpEmployeeType.TabStop = false;
            this.grpEmployeeType.Text = "EmployeeType";
            this.grpEmployeeType.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioConsultant
            // 
            this.radioConsultant.AutoSize = true;
            this.radioConsultant.Location = new System.Drawing.Point(6, 68);
            this.radioConsultant.Name = "radioConsultant";
            this.radioConsultant.Size = new System.Drawing.Size(75, 17);
            this.radioConsultant.TabIndex = 0;
            this.radioConsultant.TabStop = true;
            this.radioConsultant.Text = "Consultant";
            this.radioConsultant.UseVisualStyleBackColor = true;
            // 
            // radioPayroll
            // 
            this.radioPayroll.AutoSize = true;
            this.radioPayroll.Location = new System.Drawing.Point(13, 32);
            this.radioPayroll.Name = "radioPayroll";
            this.radioPayroll.Size = new System.Drawing.Size(56, 17);
            this.radioPayroll.TabIndex = 1;
            this.radioPayroll.TabStop = true;
            this.radioPayroll.Text = "Payroll";
            this.radioPayroll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpEmployeeType);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtEmployeeName);
            this.Controls.Add(this.TxtEmployeeNo);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.lblEmployeeNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpEmployeeType.ResumeLayout(false);
            this.grpEmployeeType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeNo;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox TxtEmployeeNo;
        private System.Windows.Forms.TextBox TxtEmployeeName;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpEmployeeType;
        private System.Windows.Forms.RadioButton radioPayroll;
        private System.Windows.Forms.RadioButton radioConsultant;
    }
}

