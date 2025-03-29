namespace JobApp
{
    partial class AccountForm
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(6, 10);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(6, 10, 3, 10);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(28, 30);
            this.labelFIO.TabIndex = 68;
            this.labelFIO.Text = "...";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Location = new System.Drawing.Point(19, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(729, 201);
            this.guna2Panel1.TabIndex = 69;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelFIO);
            this.flowLayoutPanel1.Controls.Add(this.labelUsername);
            this.flowLayoutPanel1.Controls.Add(this.labelPassword);
            this.flowLayoutPanel1.Controls.Add(this.labelPhone);
            this.flowLayoutPanel1.Controls.Add(this.labelEmail);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(723, 195);
            this.flowLayoutPanel1.TabIndex = 73;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(6, 60);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(6, 10, 3, 6);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(17, 17);
            this.labelUsername.TabIndex = 69;
            this.labelUsername.Text = "...";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(6, 93);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(6, 10, 3, 6);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(17, 17);
            this.labelPassword.TabIndex = 70;
            this.labelPassword.Text = "...";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(6, 126);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(6, 10, 3, 6);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(17, 17);
            this.labelPhone.TabIndex = 71;
            this.labelPhone.Text = "...";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmail.Location = new System.Drawing.Point(6, 159);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(6, 10, 3, 6);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(17, 17);
            this.labelEmail.TabIndex = 72;
            this.labelEmail.Text = "...";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 294);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.guna2Panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label labelFIO;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.Label labelPhone;
        public System.Windows.Forms.Label labelPassword;
        public System.Windows.Forms.Label labelUsername;
    }
}