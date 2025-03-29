namespace JobApp
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SignInButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.toggleSwitchPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.textLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragStartTransparencyValue = 1D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // SignInButton
            // 
            this.SignInButton.Animated = true;
            this.SignInButton.BorderColor = System.Drawing.Color.Silver;
            this.SignInButton.BorderRadius = 10;
            this.SignInButton.BorderThickness = 1;
            this.SignInButton.DisabledState.BorderColor = System.Drawing.Color.Silver;
            this.SignInButton.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.SignInButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.SignInButton.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.SignInButton.FillColor = System.Drawing.Color.White;
            this.SignInButton.FocusedColor = System.Drawing.Color.White;
            this.SignInButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignInButton.ForeColor = System.Drawing.Color.Black;
            this.SignInButton.HoverState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SignInButton.HoverState.FillColor = System.Drawing.Color.White;
            this.SignInButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.SignInButton.Location = new System.Drawing.Point(108, 272);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(232, 35);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Войти";
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.toggleSwitchPassword);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.textPassword);
            this.guna2Panel1.Controls.Add(this.textLogin);
            this.guna2Panel1.Location = new System.Drawing.Point(33, 116);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(382, 135);
            this.guna2Panel1.TabIndex = 3;
            // 
            // toggleSwitchPassword
            // 
            this.toggleSwitchPassword.Animated = true;
            this.toggleSwitchPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleSwitchPassword.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleSwitchPassword.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleSwitchPassword.Location = new System.Drawing.Point(324, 91);
            this.toggleSwitchPassword.Name = "toggleSwitchPassword";
            this.toggleSwitchPassword.Size = new System.Drawing.Size(44, 20);
            this.toggleSwitchPassword.TabIndex = 9;
            this.toggleSwitchPassword.UncheckedState.BorderColor = System.Drawing.Color.Silver;
            this.toggleSwitchPassword.UncheckedState.BorderThickness = 1;
            this.toggleSwitchPassword.UncheckedState.FillColor = System.Drawing.Color.White;
            this.toggleSwitchPassword.UncheckedState.InnerBorderColor = System.Drawing.Color.Black;
            this.toggleSwitchPassword.UncheckedState.InnerColor = System.Drawing.Color.Black;
            this.toggleSwitchPassword.CheckedChanged += new System.EventHandler(this.toggleSwitchPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // textPassword
            // 
            this.textPassword.Animated = true;
            this.textPassword.BorderColor = System.Drawing.Color.Silver;
            this.textPassword.BorderRadius = 5;
            this.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPassword.DefaultText = "";
            this.textPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textPassword.ForeColor = System.Drawing.Color.Black;
            this.textPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPassword.Location = new System.Drawing.Point(40, 87);
            this.textPassword.Name = "textPassword";
            this.textPassword.PlaceholderText = "";
            this.textPassword.SelectedText = "";
            this.textPassword.Size = new System.Drawing.Size(270, 28);
            this.textPassword.TabIndex = 6;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textLogin
            // 
            this.textLogin.Animated = true;
            this.textLogin.BorderColor = System.Drawing.Color.Silver;
            this.textLogin.BorderRadius = 5;
            this.textLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLogin.DefaultText = "";
            this.textLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLogin.ForeColor = System.Drawing.Color.Black;
            this.textLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLogin.Location = new System.Drawing.Point(40, 29);
            this.textLogin.Name = "textLogin";
            this.textLogin.PlaceholderText = "";
            this.textLogin.SelectedText = "";
            this.textLogin.Size = new System.Drawing.Size(270, 28);
            this.textLogin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Работа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Войдите в свою учетную запись";
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.DisabledState.BorderColor = System.Drawing.Color.White;
            this.buttonClose.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.buttonClose.DisabledState.FillColor = System.Drawing.Color.White;
            this.buttonClose.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.FillColor = System.Drawing.Color.White;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.Image = global::JobApp.Properties.Resources.Close_Windowfill;
            this.buttonClose.Image = global::JobApp.Properties.Resources.Close_Window;
            this.buttonClose.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonClose.Location = new System.Drawing.Point(416, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.PressedColor = System.Drawing.Color.White;
            this.buttonClose.Size = new System.Drawing.Size(28, 28);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 319);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.SignInButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(444, 319);
            this.MinimumSize = new System.Drawing.Size(444, 319);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button buttonClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TextBox textPassword;
        public Guna.UI2.WinForms.Guna2TextBox textLogin;
        public Guna.UI2.WinForms.Guna2Button SignInButton;
        public Guna.UI2.WinForms.Guna2ToggleSwitch toggleSwitchPassword;
    }
}

