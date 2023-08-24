namespace H2H_App
{
    partial class MainmenuForm
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
            this.BilingBtn = new System.Windows.Forms.Button();
            this.CashierBtn = new System.Windows.Forms.Button();
            this.H2H_lbl = new System.Windows.Forms.Label();
            this.ExitBtn = new PharmacyProject.CircularButton();
            this.SuspendLayout();
            // 
            // BilingBtn
            // 
            this.BilingBtn.BackColor = System.Drawing.Color.Transparent;
            this.BilingBtn.BackgroundImage = global::H2H_App.Properties.Resources.bill_png;
            this.BilingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BilingBtn.Location = new System.Drawing.Point(696, 153);
            this.BilingBtn.Name = "BilingBtn";
            this.BilingBtn.Size = new System.Drawing.Size(225, 222);
            this.BilingBtn.TabIndex = 2;
            this.BilingBtn.UseVisualStyleBackColor = false;
            this.BilingBtn.Click += new System.EventHandler(this.BilingBtn_Click);
            // 
            // CashierBtn
            // 
            this.CashierBtn.BackColor = System.Drawing.Color.Transparent;
            this.CashierBtn.BackgroundImage = global::H2H_App.Properties.Resources.cashier_2_2_;
            this.CashierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CashierBtn.Location = new System.Drawing.Point(402, 153);
            this.CashierBtn.Name = "CashierBtn";
            this.CashierBtn.Size = new System.Drawing.Size(228, 222);
            this.CashierBtn.TabIndex = 1;
            this.CashierBtn.UseVisualStyleBackColor = false;
            this.CashierBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // H2H_lbl
            // 
            this.H2H_lbl.AutoSize = true;
            this.H2H_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H2H_lbl.ForeColor = System.Drawing.Color.GhostWhite;
            this.H2H_lbl.Location = new System.Drawing.Point(549, 9);
            this.H2H_lbl.Name = "H2H_lbl";
            this.H2H_lbl.Size = new System.Drawing.Size(233, 50);
            this.H2H_lbl.TabIndex = 12;
            this.H2H_lbl.Text = "MainMenu";
            this.H2H_lbl.UseMnemonic = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = global::H2H_App.Properties.Resources.x_2925826_640;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Location = new System.Drawing.Point(1254, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(44, 44);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainmenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1310, 589);
            this.Controls.Add(this.H2H_lbl);
            this.Controls.Add(this.BilingBtn);
            this.Controls.Add(this.CashierBtn);
            this.Controls.Add(this.ExitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainmenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainmenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyProject.CircularButton ExitBtn;
        private System.Windows.Forms.Button CashierBtn;
        private System.Windows.Forms.Button BilingBtn;
        private System.Windows.Forms.Label H2H_lbl;
    }
}