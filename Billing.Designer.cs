namespace H2H_App
{
    partial class Billing
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
            this.process_TB = new System.Windows.Forms.TextBox();
            this.electronicFee_TB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.H2H_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.Print_TB = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.ADD_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cusName_TB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subtotalTb = new System.Windows.Forms.TextBox();
            this.grdTotalTb = new System.Windows.Forms.TextBox();
            this.dicountView = new System.Windows.Forms.TextBox();
            this.dicountTb = new System.Windows.Forms.TextBox();
            this.paymentTypeCB = new System.Windows.Forms.ComboBox();
            this.paymentStatusCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.orederProfitTB = new System.Windows.Forms.TextBox();
            this.minus_Money_statusCB = new System.Windows.Forms.ComboBox();
            this.dailyCashiergrid = new System.Windows.Forms.DataGridView();
            this.lblTotalVisa = new System.Windows.Forms.Label();
            this.lblTotalCash = new System.Windows.Forms.Label();
            this.AddAcountBtn = new System.Windows.Forms.Button();
            this.AccountNameCB = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyCashiergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // process_TB
            // 
            this.process_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.process_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.process_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.process_TB.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.process_TB.Location = new System.Drawing.Point(1561, 131);
            this.process_TB.Name = "process_TB";
            this.process_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.process_TB.Size = new System.Drawing.Size(203, 28);
            this.process_TB.TabIndex = 1;
            // 
            // electronicFee_TB
            // 
            this.electronicFee_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.electronicFee_TB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.electronicFee_TB.Location = new System.Drawing.Point(1315, 131);
            this.electronicFee_TB.Name = "electronicFee_TB";
            this.electronicFee_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.electronicFee_TB.Size = new System.Drawing.Size(203, 28);
            this.electronicFee_TB.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(1545, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // H2H_lbl
            // 
            this.H2H_lbl.AutoSize = true;
            this.H2H_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H2H_lbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.H2H_lbl.Location = new System.Drawing.Point(790, 23);
            this.H2H_lbl.Name = "H2H_lbl";
            this.H2H_lbl.Size = new System.Drawing.Size(272, 50);
            this.H2H_lbl.TabIndex = 11;
            this.H2H_lbl.Text = "Daily Cashier";
            this.H2H_lbl.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Controls.Add(this.BackBtn);
            this.groupBox1.Controls.Add(this.H2H_lbl);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1786, 86);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::H2H_App.Properties.Resources.download;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(53, 40);
            this.BackBtn.TabIndex = 33;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click_1);
            // 
            // Print_TB
            // 
            this.Print_TB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Print_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Print_TB.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Print_TB.Location = new System.Drawing.Point(408, 117);
            this.Print_TB.Name = "Print_TB";
            this.Print_TB.Size = new System.Drawing.Size(135, 50);
            this.Print_TB.TabIndex = 11;
            this.Print_TB.Text = "طباعة";
            this.Print_TB.UseVisualStyleBackColor = true;
            this.Print_TB.Click += new System.EventHandler(this.Print_TB_Click);
            // 
            // Description
            // 
            this.Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Description.AutoSize = true;
            this.Description.BackColor = System.Drawing.Color.Transparent;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Description.Location = new System.Drawing.Point(1662, 106);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(99, 23);
            this.Description.TabIndex = 15;
            this.Description.Text = "نوع المعامله";
            // 
            // Discount
            // 
            this.Discount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Discount.AutoSize = true;
            this.Discount.BackColor = System.Drawing.Color.Transparent;
            this.Discount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Discount.Location = new System.Drawing.Point(1381, 106);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(135, 23);
            this.Discount.TabIndex = 25;
            this.Discount.Text = "الرسوم الألكترونية";
            // 
            // ADD_Btn
            // 
            this.ADD_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ADD_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_Btn.ForeColor = System.Drawing.Color.ForestGreen;
            this.ADD_Btn.Location = new System.Drawing.Point(408, 258);
            this.ADD_Btn.Name = "ADD_Btn";
            this.ADD_Btn.Size = new System.Drawing.Size(135, 50);
            this.ADD_Btn.TabIndex = 10;
            this.ADD_Btn.Text = "اضافة";
            this.ADD_Btn.UseVisualStyleBackColor = true;
            this.ADD_Btn.Click += new System.EventHandler(this.ADD_Btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(972, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "اسم العميل";
            // 
            // cusName_TB
            // 
            this.cusName_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cusName_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cusName_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cusName_TB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.cusName_TB.Location = new System.Drawing.Point(859, 131);
            this.cusName_TB.Name = "cusName_TB";
            this.cusName_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cusName_TB.Size = new System.Drawing.Size(203, 28);
            this.cusName_TB.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.subtotalTb);
            this.groupBox2.Controls.Add(this.grdTotalTb);
            this.groupBox2.Controls.Add(this.dicountView);
            this.groupBox2.Controls.Add(this.dicountTb);
            this.groupBox2.Location = new System.Drawing.Point(43, 107);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(359, 201);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // subtotalTb
            // 
            this.subtotalTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subtotalTb.Enabled = false;
            this.subtotalTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.subtotalTb.ForeColor = System.Drawing.Color.Firebrick;
            this.subtotalTb.Location = new System.Drawing.Point(52, 23);
            this.subtotalTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subtotalTb.Name = "subtotalTb";
            this.subtotalTb.Size = new System.Drawing.Size(265, 34);
            this.subtotalTb.TabIndex = 27;
            this.subtotalTb.Text = "الأجمالي الفرعي";
            this.subtotalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grdTotalTb
            // 
            this.grdTotalTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grdTotalTb.Enabled = false;
            this.grdTotalTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grdTotalTb.ForeColor = System.Drawing.Color.Firebrick;
            this.grdTotalTb.Location = new System.Drawing.Point(51, 140);
            this.grdTotalTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdTotalTb.Name = "grdTotalTb";
            this.grdTotalTb.Size = new System.Drawing.Size(266, 34);
            this.grdTotalTb.TabIndex = 30;
            this.grdTotalTb.Text = "الاجمالي(بعد الضريبةو الخصم)";
            this.grdTotalTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dicountView
            // 
            this.dicountView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dicountView.Enabled = false;
            this.dicountView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dicountView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dicountView.Location = new System.Drawing.Point(51, 79);
            this.dicountView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dicountView.Name = "dicountView";
            this.dicountView.Size = new System.Drawing.Size(86, 34);
            this.dicountView.TabIndex = 32;
            this.dicountView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dicountTb
            // 
            this.dicountTb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dicountTb.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dicountTb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dicountTb.Location = new System.Drawing.Point(143, 79);
            this.dicountTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dicountTb.Name = "dicountTb";
            this.dicountTb.Size = new System.Drawing.Size(174, 34);
            this.dicountTb.TabIndex = 9;
            this.dicountTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dicountTb.Enter += new System.EventHandler(this.dicountTb_GotFocus);
            this.dicountTb.Leave += new System.EventHandler(this.dicountTb_LostFocus);
            // 
            // paymentTypeCB
            // 
            this.paymentTypeCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentTypeCB.DisplayMember = "الرئيسية";
            this.paymentTypeCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.paymentTypeCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paymentTypeCB.FormattingEnabled = true;
            this.paymentTypeCB.Items.AddRange(new object[] {
            "كاش",
            "فيزا",
            "لم يتم التحصيل"});
            this.paymentTypeCB.Location = new System.Drawing.Point(1319, 197);
            this.paymentTypeCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentTypeCB.Name = "paymentTypeCB";
            this.paymentTypeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentTypeCB.Size = new System.Drawing.Size(199, 36);
            this.paymentTypeCB.TabIndex = 7;
            this.paymentTypeCB.Text = "التحصيل";
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
            this.paymentStatusCB.Location = new System.Drawing.Point(1565, 197);
            this.paymentStatusCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paymentStatusCB.Name = "paymentStatusCB";
            this.paymentStatusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.paymentStatusCB.Size = new System.Drawing.Size(199, 36);
            this.paymentStatusCB.TabIndex = 6;
            this.paymentStatusCB.Text = "حالة الدفع";
            this.paymentStatusCB.SelectionChangeCommitted += new System.EventHandler(this.paymentMethodComboBox_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(1181, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "ربح المعامله";
            // 
            // orederProfitTB
            // 
            this.orederProfitTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orederProfitTB.Font = new System.Drawing.Font("Arial", 10.8F);
            this.orederProfitTB.Location = new System.Drawing.Point(1079, 131);
            this.orederProfitTB.Name = "orederProfitTB";
            this.orederProfitTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.orederProfitTB.Size = new System.Drawing.Size(203, 28);
            this.orederProfitTB.TabIndex = 3;
            // 
            // minus_Money_statusCB
            // 
            this.minus_Money_statusCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minus_Money_statusCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.minus_Money_statusCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.minus_Money_statusCB.FormattingEnabled = true;
            this.minus_Money_statusCB.Items.AddRange(new object[] {
            "كاش",
            "فيزا",
            "لم يتم الخصم"});
            this.minus_Money_statusCB.Location = new System.Drawing.Point(1083, 197);
            this.minus_Money_statusCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minus_Money_statusCB.Name = "minus_Money_statusCB";
            this.minus_Money_statusCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minus_Money_statusCB.Size = new System.Drawing.Size(199, 36);
            this.minus_Money_statusCB.TabIndex = 8;
            this.minus_Money_statusCB.Text = "خصم المعامله";
            // 
            // dailyCashiergrid
            // 
            this.dailyCashiergrid.AllowUserToAddRows = false;
            this.dailyCashiergrid.AllowUserToDeleteRows = false;
            this.dailyCashiergrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dailyCashiergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dailyCashiergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dailyCashiergrid.Location = new System.Drawing.Point(12, 362);
            this.dailyCashiergrid.Name = "dailyCashiergrid";
            this.dailyCashiergrid.ReadOnly = true;
            this.dailyCashiergrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dailyCashiergrid.RowHeadersWidth = 51;
            this.dailyCashiergrid.RowTemplate.Height = 24;
            this.dailyCashiergrid.Size = new System.Drawing.Size(1762, 529);
            this.dailyCashiergrid.TabIndex = 13;
            // 
            // lblTotalVisa
            // 
            this.lblTotalVisa.AutoSize = true;
            this.lblTotalVisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVisa.ForeColor = System.Drawing.Color.Red;
            this.lblTotalVisa.Location = new System.Drawing.Point(1093, 297);
            this.lblTotalVisa.Name = "lblTotalVisa";
            this.lblTotalVisa.Size = new System.Drawing.Size(98, 22);
            this.lblTotalVisa.TabIndex = 59;
            this.lblTotalVisa.Text = "أجمالي الفيزا";
            // 
            // lblTotalCash
            // 
            this.lblTotalCash.AutoSize = true;
            this.lblTotalCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCash.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCash.Location = new System.Drawing.Point(1611, 297);
            this.lblTotalCash.Name = "lblTotalCash";
            this.lblTotalCash.Size = new System.Drawing.Size(101, 22);
            this.lblTotalCash.TabIndex = 58;
            this.lblTotalCash.Text = "أجمالي الكاش";
            // 
            // AddAcountBtn
            // 
            this.AddAcountBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAcountBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddAcountBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAcountBtn.ForeColor = System.Drawing.Color.Green;
            this.AddAcountBtn.Location = new System.Drawing.Point(811, 199);
            this.AddAcountBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAcountBtn.Name = "AddAcountBtn";
            this.AddAcountBtn.Size = new System.Drawing.Size(46, 36);
            this.AddAcountBtn.TabIndex = 57;
            this.AddAcountBtn.Text = "+";
            this.AddAcountBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddAcountBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddAcountBtn.UseVisualStyleBackColor = true;
            // 
            // AccountNameCB
            // 
            this.AccountNameCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNameCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AccountNameCB.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AccountNameCB.FormattingEnabled = true;
            this.AccountNameCB.Location = new System.Drawing.Point(863, 197);
            this.AccountNameCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AccountNameCB.Name = "AccountNameCB";
            this.AccountNameCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountNameCB.Size = new System.Drawing.Size(199, 36);
            this.AccountNameCB.TabIndex = 5;
            this.AccountNameCB.Text = "اسم الحساب";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1786, 903);
            this.Controls.Add(this.AccountNameCB);
            this.Controls.Add(this.lblTotalVisa);
            this.Controls.Add(this.lblTotalCash);
            this.Controls.Add(this.dailyCashiergrid);
            this.Controls.Add(this.AddAcountBtn);
            this.Controls.Add(this.minus_Money_statusCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ADD_Btn);
            this.Controls.Add(this.orederProfitTB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentTypeCB);
            this.Controls.Add(this.Print_TB);
            this.Controls.Add(this.cusName_TB);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.paymentStatusCB);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.electronicFee_TB);
            this.Controls.Add(this.process_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Invoice_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Invoice_Form_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dailyCashiergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox process_TB;
        private System.Windows.Forms.TextBox electronicFee_TB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label H2H_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Print_TB;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Button ADD_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusName_TB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox subtotalTb;
        private System.Windows.Forms.TextBox grdTotalTb;
        private System.Windows.Forms.TextBox dicountView;
        private System.Windows.Forms.ComboBox paymentTypeCB;
        private System.Windows.Forms.ComboBox paymentStatusCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orederProfitTB;
        private System.Windows.Forms.ComboBox minus_Money_statusCB;
        private System.Windows.Forms.DataGridView dailyCashiergrid;
        public System.Windows.Forms.TextBox dicountTb;
        private System.Windows.Forms.Label lblTotalVisa;
        private System.Windows.Forms.Label lblTotalCash;
        private System.Windows.Forms.Button AddAcountBtn;
        private System.Windows.Forms.ComboBox AccountNameCB;
        private System.Windows.Forms.Button BackBtn;
    }
}

