namespace H2H_App
{
    partial class EmployeeForm
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
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.InsertEmpBtn = new System.Windows.Forms.Button();
            this.phoneEmployeeTB = new System.Windows.Forms.TextBox();
            this.nameEmpLoyeeTB = new System.Windows.Forms.TextBox();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.empPositionCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.ForeColor = System.Drawing.Color.Blue;
            this.labelCompanyName.Location = new System.Drawing.Point(141, 292);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(154, 46);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "AirBird";
            // 
            // InsertEmpBtn
            // 
            this.InsertEmpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertEmpBtn.BackColor = System.Drawing.Color.Blue;
            this.InsertEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertEmpBtn.ForeColor = System.Drawing.Color.White;
            this.InsertEmpBtn.Location = new System.Drawing.Point(270, 381);
            this.InsertEmpBtn.Name = "InsertEmpBtn";
            this.InsertEmpBtn.Size = new System.Drawing.Size(80, 41);
            this.InsertEmpBtn.TabIndex = 5;
            this.InsertEmpBtn.Text = "ADD";
            this.InsertEmpBtn.UseVisualStyleBackColor = false;
            this.InsertEmpBtn.Click += new System.EventHandler(this.InsertEmpBtn_Click);
            // 
            // phoneEmployeeTB
            // 
            this.phoneEmployeeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneEmployeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneEmployeeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.phoneEmployeeTB.Location = new System.Drawing.Point(54, 189);
            this.phoneEmployeeTB.Name = "phoneEmployeeTB";
            this.phoneEmployeeTB.Size = new System.Drawing.Size(296, 30);
            this.phoneEmployeeTB.TabIndex = 2;
            this.phoneEmployeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nameEmpLoyeeTB
            // 
            this.nameEmpLoyeeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameEmpLoyeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameEmpLoyeeTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nameEmpLoyeeTB.Location = new System.Drawing.Point(54, 112);
            this.nameEmpLoyeeTB.Name = "nameEmpLoyeeTB";
            this.nameEmpLoyeeTB.Size = new System.Drawing.Size(296, 30);
            this.nameEmpLoyeeTB.TabIndex = 1;
            this.nameEmpLoyeeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EmailTB
            // 
            this.EmailTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailTB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.EmailTB.Location = new System.Drawing.Point(54, 261);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(296, 30);
            this.EmailTB.TabIndex = 3;
            this.EmailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // empPositionCB
            // 
            this.empPositionCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.empPositionCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.empPositionCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.empPositionCB.FormattingEnabled = true;
            this.empPositionCB.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.empPositionCB.Location = new System.Drawing.Point(55, 323);
            this.empPositionCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empPositionCB.Name = "empPositionCB";
            this.empPositionCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.empPositionCB.Size = new System.Drawing.Size(295, 33);
            this.empPositionCB.TabIndex = 4;
            this.empPositionCB.Text = "مدير/موظف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Full Name:";
            // 
            // backBTN
            // 
            this.backBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backBTN.BackColor = System.Drawing.Color.Blue;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.White;
            this.backBTN.Location = new System.Drawing.Point(439, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(49, 40);
            this.backBTN.TabIndex = 17;
            this.backBTN.Text = ">>";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(142, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Employee";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empPositionCB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.InsertEmpBtn);
            this.Controls.Add(this.phoneEmployeeTB);
            this.Controls.Add(this.nameEmpLoyeeTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Button InsertEmpBtn;
        private System.Windows.Forms.TextBox phoneEmployeeTB;
        private System.Windows.Forms.TextBox nameEmpLoyeeTB;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.ComboBox empPositionCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label1;
    }
}