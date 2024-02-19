namespace Music_Studio
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.DashboardLabel = new System.Windows.Forms.Label();
            this.PckBtn = new System.Windows.Forms.Button();
            this.InstBtn = new System.Windows.Forms.Button();
            this.CustBtn = new System.Windows.Forms.Button();
            this.EmpBtn = new System.Windows.Forms.Button();
            this.RptBtn = new System.Windows.Forms.Button();
            this.RsvBtn = new System.Windows.Forms.Button();
            this.InfBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DashboardLabel
            // 
            this.DashboardLabel.AutoSize = true;
            this.DashboardLabel.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DashboardLabel.Location = new System.Drawing.Point(325, 27);
            this.DashboardLabel.Name = "DashboardLabel";
            this.DashboardLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DashboardLabel.Size = new System.Drawing.Size(685, 57);
            this.DashboardLabel.TabIndex = 1;
            this.DashboardLabel.Text = "Naada Music Studio and Record Bar";
            // 
            // PckBtn
            // 
            this.PckBtn.BackColor = System.Drawing.Color.MintCream;
            this.PckBtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PckBtn.Location = new System.Drawing.Point(551, 142);
            this.PckBtn.Name = "PckBtn";
            this.PckBtn.Size = new System.Drawing.Size(240, 220);
            this.PckBtn.TabIndex = 3;
            this.PckBtn.Text = "Packages";
            this.PckBtn.UseVisualStyleBackColor = false;
            // 
            // InstBtn
            // 
            this.InstBtn.BackColor = System.Drawing.Color.MintCream;
            this.InstBtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstBtn.Location = new System.Drawing.Point(956, 142);
            this.InstBtn.Name = "InstBtn";
            this.InstBtn.Size = new System.Drawing.Size(240, 220);
            this.InstBtn.TabIndex = 4;
            this.InstBtn.Text = "Instruments";
            this.InstBtn.UseVisualStyleBackColor = false;
            this.InstBtn.Click += new System.EventHandler(this.InstBtn_Click);
            // 
            // CustBtn
            // 
            this.CustBtn.BackColor = System.Drawing.Color.MintCream;
            this.CustBtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustBtn.Location = new System.Drawing.Point(156, 419);
            this.CustBtn.Name = "CustBtn";
            this.CustBtn.Size = new System.Drawing.Size(240, 220);
            this.CustBtn.TabIndex = 7;
            this.CustBtn.Text = "Customers";
            this.CustBtn.UseVisualStyleBackColor = false;
            this.CustBtn.Click += new System.EventHandler(this.CustBtn_Click);
            // 
            // EmpBtn
            // 
            this.EmpBtn.BackColor = System.Drawing.Color.MintCream;
            this.EmpBtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpBtn.Location = new System.Drawing.Point(551, 419);
            this.EmpBtn.Name = "EmpBtn";
            this.EmpBtn.Size = new System.Drawing.Size(240, 220);
            this.EmpBtn.TabIndex = 6;
            this.EmpBtn.Text = "Employees";
            this.EmpBtn.UseVisualStyleBackColor = false;
            this.EmpBtn.Click += new System.EventHandler(this.EmpBtn_Click);
            // 
            // RptBtn
            // 
            this.RptBtn.BackColor = System.Drawing.Color.MintCream;
            this.RptBtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RptBtn.Location = new System.Drawing.Point(956, 419);
            this.RptBtn.Name = "RptBtn";
            this.RptBtn.Size = new System.Drawing.Size(240, 220);
            this.RptBtn.TabIndex = 5;
            this.RptBtn.Text = "Reports";
            this.RptBtn.UseVisualStyleBackColor = false;
            // 
            // RsvBtn
            // 
            this.RsvBtn.BackColor = System.Drawing.Color.MintCream;
            this.RsvBtn.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RsvBtn.Location = new System.Drawing.Point(156, 142);
            this.RsvBtn.Name = "RsvBtn";
            this.RsvBtn.Size = new System.Drawing.Size(240, 220);
            this.RsvBtn.TabIndex = 8;
            this.RsvBtn.Text = "Make Reservations";
            this.RsvBtn.UseVisualStyleBackColor = false;
            // 
            // InfBtn
            // 
            this.InfBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InfBtn.BackgroundImage")));
            this.InfBtn.Location = new System.Drawing.Point(1292, 653);
            this.InfBtn.Name = "InfBtn";
            this.InfBtn.Size = new System.Drawing.Size(32, 33);
            this.InfBtn.TabIndex = 9;
            this.InfBtn.UseVisualStyleBackColor = true;
            this.InfBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1346, 698);
            this.Controls.Add(this.InfBtn);
            this.Controls.Add(this.RsvBtn);
            this.Controls.Add(this.CustBtn);
            this.Controls.Add(this.EmpBtn);
            this.Controls.Add(this.RptBtn);
            this.Controls.Add(this.InstBtn);
            this.Controls.Add(this.PckBtn);
            this.Controls.Add(this.DashboardLabel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DashboardLabel;
        private System.Windows.Forms.Button PckBtn;
        private System.Windows.Forms.Button InstBtn;
        private System.Windows.Forms.Button CustBtn;
        private System.Windows.Forms.Button EmpBtn;
        private System.Windows.Forms.Button RptBtn;
        private System.Windows.Forms.Button RsvBtn;
        private System.Windows.Forms.Button InfBtn;
    }
}