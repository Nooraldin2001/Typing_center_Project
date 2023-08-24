namespace H2H_App
{
    partial class ReportsForm
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
            this.ReportsGrid = new System.Windows.Forms.DataGridView();
            this.lblSumTotal = new System.Windows.Forms.Label();
            this.filter_Btn = new System.Windows.Forms.Button();
            this.paymentStatusCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cusName_TB = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.FilterdTP = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.H2H_lbl = new System.Windows.Forms.Label();
            this.lblSumOrderProfit = new System.Windows.Forms.Label();
            this.lblTotalDiebt = new System.Windows.Forms.Label();
            this.lblTotalGiven = new System.Windows.Forms.Label();
            this.ShowCriedtBtn = new System.Windows.Forms.Button();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.lblTotalVisa = new System.Windows.Forms.Label();
            this.PrintReports_TB = new System.Windows.Forms.Button();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.employeeCB = new System.Windows.Forms.ComboBox();
            this.SearchEmpBtn = new System.Windows.Forms.Button();
            this.SignInLogData = new System.Windows.Forms.Button();
            this.ShowEmpAccountsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReportsGrid
            // 
            this.ReportsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReportsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ReportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportsGrid.Location = new System.Drawing.Point(12, 267);
            this.ReportsGrid.Name = "ReportsGrid";
            this.ReportsGrid.RowHeadersWidth = 51;
            this.ReportsGrid.RowTemplate.Height = 24;
            this.ReportsGrid.Size = new System.Drawing.Size(1813, 628);
            this.ReportsGrid.TabIndex = 0;
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumTotal.ForeColor = System.Drawing.Color.Red;
            this.lblSumTotal.Location = new System.Drawing.Point(79, 137);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Size = new System.Drawing.Size(132, 22);
            this.lblSumTotal.TabIndex = 1;
            this.lblSumTotal.Text = "أجمالي المدفوعات";
            // 
            // filter_Btn
            // 
            this.filter_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filter_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter_Btn.ForeColor = System.Drawing.Color.ForestGreen;
            this.filter_Btn.Location = new System.Drawing.Point(954, 113);
            this.filter_Btn.Name = "filter_Btn";
            this.filter_Btn.Size = new System.Drawing.Size(126, 36);
            this.filter_Btn.TabIndex = 13;
            this.filter_Btn.Text = "بحث";
            this.filter_Btn.UseVisualStyleBackColor = true;
            this.filter_Btn.Click += new System.EventHandler(this.filter_Btn_Click);
            // 
            // paymentStatusCB
            // 
            this.paymentStatusCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentStatusCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paymentStatusCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paymentStatusCB.FormattingEnabled = true;
            this.paymentStatusCB.Items.AddRange(new object[] {
            "مؤجل",
            "مقدم",
            "مدفوع"});
            this.paymentStatusCB.Location = new System.Drawing.Point(1620, 113);
            this.paymentStatusCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentStatusCB.Name = "paymentStatusCB";
            this.paymentStatusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentStatusCB.Size = new System.Drawing.Size(199, 36);
            this.paymentStatusCB.TabIndex = 14;
            this.paymentStatusCB.Text = "حالة الدفع";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(1485, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "اسم العميل";
            // 
            // cusName_TB
            // 
            this.cusName_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusName_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cusName_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cusName_TB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cusName_TB.Location = new System.Drawing.Point(1372, 121);
            this.cusName_TB.Name = "cusName_TB";
            this.cusName_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusName_TB.Size = new System.Drawing.Size(203, 28);
            this.cusName_TB.TabIndex = 29;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::H2H_App.Properties.Resources.download;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Location = new System.Drawing.Point(12, 21);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(53, 40);
            this.BackBtn.TabIndex = 32;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FilterdTP
            // 
            this.FilterdTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FilterdTP.Location = new System.Drawing.Point(1106, 124);
            this.FilterdTP.Name = "FilterdTP";
            this.FilterdTP.Size = new System.Drawing.Size(250, 22);
            this.FilterdTP.TabIndex = 31;
            this.FilterdTP.Leave += new System.EventHandler(this.FilterdTP_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Controls.Add(this.H2H_lbl);
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1837, 86);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // H2H_lbl
            // 
            this.H2H_lbl.AutoSize = true;
            this.H2H_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H2H_lbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.H2H_lbl.Location = new System.Drawing.Point(836, 23);
            this.H2H_lbl.Name = "H2H_lbl";
            this.H2H_lbl.Size = new System.Drawing.Size(174, 50);
            this.H2H_lbl.TabIndex = 11;
            this.H2H_lbl.Text = "Reports";
            this.H2H_lbl.UseMnemonic = false;
            // 
            // lblSumOrderProfit
            // 
            this.lblSumOrderProfit.AutoSize = true;
            this.lblSumOrderProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumOrderProfit.ForeColor = System.Drawing.Color.Red;
            this.lblSumOrderProfit.Location = new System.Drawing.Point(99, 99);
            this.lblSumOrderProfit.Name = "lblSumOrderProfit";
            this.lblSumOrderProfit.Size = new System.Drawing.Size(98, 22);
            this.lblSumOrderProfit.TabIndex = 34;
            this.lblSumOrderProfit.Text = "أجمالي الربح";
            // 
            // lblTotalDiebt
            // 
            this.lblTotalDiebt.AutoSize = true;
            this.lblTotalDiebt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiebt.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDiebt.Location = new System.Drawing.Point(523, 99);
            this.lblTotalDiebt.Name = "lblTotalDiebt";
            this.lblTotalDiebt.Size = new System.Drawing.Size(99, 22);
            this.lblTotalDiebt.TabIndex = 36;
            this.lblTotalDiebt.Text = "أجمالي الأجل";
            // 
            // lblTotalGiven
            // 
            this.lblTotalGiven.AutoSize = true;
            this.lblTotalGiven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGiven.ForeColor = System.Drawing.Color.Red;
            this.lblTotalGiven.Location = new System.Drawing.Point(523, 137);
            this.lblTotalGiven.Name = "lblTotalGiven";
            this.lblTotalGiven.Size = new System.Drawing.Size(100, 22);
            this.lblTotalGiven.TabIndex = 35;
            this.lblTotalGiven.Text = "أجمالي المقدم";
            // 
            // ShowCriedtBtn
            // 
            this.ShowCriedtBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowCriedtBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCriedtBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.ShowCriedtBtn.Location = new System.Drawing.Point(919, 162);
            this.ShowCriedtBtn.Name = "ShowCriedtBtn";
            this.ShowCriedtBtn.Size = new System.Drawing.Size(189, 36);
            this.ShowCriedtBtn.TabIndex = 37;
            this.ShowCriedtBtn.Text = "أظهار رصيد العملاء";
            this.ShowCriedtBtn.UseVisualStyleBackColor = true;
            this.ShowCriedtBtn.Click += new System.EventHandler(this.ShowCriedtBtn_Click);
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.AutoSize = true;
            this.lblTotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCash.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCash.Location = new System.Drawing.Point(522, 180);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(101, 22);
            this.lblTotalCash.TabIndex = 38;
            this.lblTotalCash.Text = "أجمالي الكاش";
            // 
            // lblTotalVisa
            // 
            this.lblTotalVisa.AutoSize = true;
            this.lblTotalVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVisa.ForeColor = System.Drawing.Color.Red;
            this.lblTotalVisa.Location = new System.Drawing.Point(97, 180);
            this.lblTotalVisa.Name = "lblTotalVisa";
            this.lblTotalVisa.Size = new System.Drawing.Size(98, 22);
            this.lblTotalVisa.TabIndex = 39;
            this.lblTotalVisa.Text = "أجمالي الفيزا";
            // 
            // PrintReports_TB
            // 
            this.PrintReports_TB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrintReports_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.PrintReports_TB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PrintReports_TB.Location = new System.Drawing.Point(1165, 162);
            this.PrintReports_TB.Name = "PrintReports_TB";
            this.PrintReports_TB.Size = new System.Drawing.Size(121, 36);
            this.PrintReports_TB.TabIndex = 40;
            this.PrintReports_TB.Text = "طباعة";
            this.PrintReports_TB.UseVisualStyleBackColor = true;
            this.PrintReports_TB.Click += new System.EventHandler(this.PrintReports_TB_Click);
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddEmpBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmpBtn.ForeColor = System.Drawing.Color.Green;
            this.AddEmpBtn.Location = new System.Drawing.Point(1568, 168);
            this.AddEmpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(46, 36);
            this.AddEmpBtn.TabIndex = 55;
            this.AddEmpBtn.Text = "+";
            this.AddEmpBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddEmpBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddEmpBtn.UseVisualStyleBackColor = true;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmpBtn_Click);
            // 
            // employeeCB
            // 
            this.employeeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.employeeCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.employeeCB.FormattingEnabled = true;
            this.employeeCB.Location = new System.Drawing.Point(1620, 166);
            this.employeeCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.employeeCB.Name = "employeeCB";
            this.employeeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employeeCB.Size = new System.Drawing.Size(199, 36);
            this.employeeCB.TabIndex = 54;
            this.employeeCB.Text = "اسم الموظف";
            // 
            // SearchEmpBtn
            // 
            this.SearchEmpBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmpBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.SearchEmpBtn.Location = new System.Drawing.Point(1421, 168);
            this.SearchEmpBtn.Name = "SearchEmpBtn";
            this.SearchEmpBtn.Size = new System.Drawing.Size(141, 36);
            this.SearchEmpBtn.TabIndex = 56;
            this.SearchEmpBtn.Text = "بحث بأسم الموظف";
            this.SearchEmpBtn.UseVisualStyleBackColor = true;
            this.SearchEmpBtn.Click += new System.EventHandler(this.SearchEmpBtn_Click);
            // 
            // SignInLogData
            // 
            this.SignInLogData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignInLogData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInLogData.ForeColor = System.Drawing.Color.ForestGreen;
            this.SignInLogData.Location = new System.Drawing.Point(1421, 210);
            this.SignInLogData.Name = "SignInLogData";
            this.SignInLogData.Size = new System.Drawing.Size(141, 36);
            this.SignInLogData.TabIndex = 57;
            this.SignInLogData.Text = "الحضور والغياب";
            this.SignInLogData.UseVisualStyleBackColor = true;
            this.SignInLogData.Click += new System.EventHandler(this.SignInLogData_Click);
            // 
            // ShowEmpAccountsBtn
            // 
            this.ShowEmpAccountsBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShowEmpAccountsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowEmpAccountsBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.ShowEmpAccountsBtn.Location = new System.Drawing.Point(919, 204);
            this.ShowEmpAccountsBtn.Name = "ShowEmpAccountsBtn";
            this.ShowEmpAccountsBtn.Size = new System.Drawing.Size(189, 36);
            this.ShowEmpAccountsBtn.TabIndex = 58;
            this.ShowEmpAccountsBtn.Text = "أظهار رصيد الموظفين";
            this.ShowEmpAccountsBtn.UseVisualStyleBackColor = true;
            this.ShowEmpAccountsBtn.Click += new System.EventHandler(this.ShowEmpAccountsBtn_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1837, 907);
            this.Controls.Add(this.ShowEmpAccountsBtn);
            this.Controls.Add(this.SignInLogData);
            this.Controls.Add(this.SearchEmpBtn);
            this.Controls.Add(this.AddEmpBtn);
            this.Controls.Add(this.employeeCB);
            this.Controls.Add(this.PrintReports_TB);
            this.Controls.Add(this.lblTotalVisa);
            this.Controls.Add(this.lblTotalCash);
            this.Controls.Add(this.ShowCriedtBtn);
            this.Controls.Add(this.lblTotalDiebt);
            this.Controls.Add(this.lblTotalGiven);
            this.Controls.Add(this.lblSumOrderProfit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FilterdTP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cusName_TB);
            this.Controls.Add(this.paymentStatusCB);
            this.Controls.Add(this.filter_Btn);
            this.Controls.Add(this.lblSumTotal);
            this.Controls.Add(this.ReportsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ReportsGrid;
        private System.Windows.Forms.Label lblSumTotal;
        private System.Windows.Forms.Button filter_Btn;
        private System.Windows.Forms.ComboBox paymentStatusCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusName_TB;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DateTimePicker FilterdTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label H2H_lbl;
        private System.Windows.Forms.Label lblSumOrderProfit;
        private System.Windows.Forms.Label lblTotalDiebt;
        private System.Windows.Forms.Label lblTotalGiven;
        private System.Windows.Forms.Button ShowCriedtBtn;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Label lblTotalVisa;
        private System.Windows.Forms.Button PrintReports_TB;
        private System.Windows.Forms.Button AddEmpBtn;
        private System.Windows.Forms.ComboBox employeeCB;
        private System.Windows.Forms.Button SearchEmpBtn;
        private System.Windows.Forms.Button SignInLogData;
        private System.Windows.Forms.Button ShowEmpAccountsBtn;
    }
}