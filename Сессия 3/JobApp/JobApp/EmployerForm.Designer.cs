namespace JobApp
{
    partial class EmployerForm
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
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.accountButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.resumesButton = new Guna.UI2.WinForms.Guna2Button();
            this.statementsButton = new Guna.UI2.WinForms.Guna2Button();
            this.invitesButton = new Guna.UI2.WinForms.Guna2Button();
            this.buttonMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.buttonClose = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 333);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Работа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(736, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Версия 1.0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.accountButton);
            this.flowLayoutPanel1.Controls.Add(this.homeButton);
            this.flowLayoutPanel1.Controls.Add(this.resumesButton);
            this.flowLayoutPanel1.Controls.Add(this.statementsButton);
            this.flowLayoutPanel1.Controls.Add(this.invitesButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(273, 393);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(270, 51);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // accountButton
            // 
            this.accountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountButton.DisabledState.BorderColor = System.Drawing.Color.White;
            this.accountButton.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.accountButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.accountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accountButton.FillColor = System.Drawing.Color.White;
            this.accountButton.FocusedColor = System.Drawing.Color.White;
            this.accountButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.accountButton.ForeColor = System.Drawing.Color.White;
            this.accountButton.HoverState.FillColor = System.Drawing.Color.White;
            this.accountButton.HoverState.Image = global::JobApp.Properties.Resources.accfill;
            this.accountButton.Image = global::JobApp.Properties.Resources.acc;
            this.accountButton.ImageSize = new System.Drawing.Size(35, 35);
            this.accountButton.Location = new System.Drawing.Point(3, 3);
            this.accountButton.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.accountButton.Name = "accountButton";
            this.accountButton.PressedColor = System.Drawing.Color.White;
            this.accountButton.Size = new System.Drawing.Size(45, 45);
            this.accountButton.TabIndex = 15;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.DisabledState.BorderColor = System.Drawing.Color.White;
            this.homeButton.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.homeButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.homeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeButton.FillColor = System.Drawing.Color.White;
            this.homeButton.FocusedColor = System.Drawing.Color.White;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.HoverState.FillColor = System.Drawing.Color.White;
            this.homeButton.HoverState.Image = global::JobApp.Properties.Resources.Homefill;
            this.homeButton.Image = global::JobApp.Properties.Resources.Home;
            this.homeButton.ImageSize = new System.Drawing.Size(35, 35);
            this.homeButton.Location = new System.Drawing.Point(57, 3);
            this.homeButton.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.PressedColor = System.Drawing.Color.White;
            this.homeButton.Size = new System.Drawing.Size(45, 45);
            this.homeButton.TabIndex = 8;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // resumesButton
            // 
            this.resumesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resumesButton.DisabledState.BorderColor = System.Drawing.Color.White;
            this.resumesButton.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.resumesButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.resumesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resumesButton.FillColor = System.Drawing.Color.White;
            this.resumesButton.FocusedColor = System.Drawing.Color.White;
            this.resumesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.resumesButton.ForeColor = System.Drawing.Color.White;
            this.resumesButton.HoverState.FillColor = System.Drawing.Color.White;
            this.resumesButton.HoverState.Image = global::JobApp.Properties.Resources.cvfill;
            this.resumesButton.Image = global::JobApp.Properties.Resources.CV;
            this.resumesButton.ImageSize = new System.Drawing.Size(35, 35);
            this.resumesButton.Location = new System.Drawing.Point(111, 3);
            this.resumesButton.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.resumesButton.Name = "resumesButton";
            this.resumesButton.PressedColor = System.Drawing.Color.White;
            this.resumesButton.Size = new System.Drawing.Size(45, 45);
            this.resumesButton.TabIndex = 9;
            this.resumesButton.Click += new System.EventHandler(this.resumesButton_Click);
            // 
            // statementsButton
            // 
            this.statementsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statementsButton.DisabledState.BorderColor = System.Drawing.Color.White;
            this.statementsButton.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.statementsButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.statementsButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.statementsButton.FillColor = System.Drawing.Color.White;
            this.statementsButton.FocusedColor = System.Drawing.Color.White;
            this.statementsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statementsButton.ForeColor = System.Drawing.Color.White;
            this.statementsButton.HoverState.FillColor = System.Drawing.Color.White;
            this.statementsButton.HoverState.Image = global::JobApp.Properties.Resources.Invoicefill;
            this.statementsButton.Image = global::JobApp.Properties.Resources.Invoice;
            this.statementsButton.ImageSize = new System.Drawing.Size(35, 35);
            this.statementsButton.Location = new System.Drawing.Point(165, 3);
            this.statementsButton.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.statementsButton.Name = "statementsButton";
            this.statementsButton.PressedColor = System.Drawing.Color.White;
            this.statementsButton.Size = new System.Drawing.Size(45, 45);
            this.statementsButton.TabIndex = 10;
            this.statementsButton.Click += new System.EventHandler(this.statementsButton_Click);
            // 
            // invitesButton
            // 
            this.invitesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invitesButton.DisabledState.BorderColor = System.Drawing.Color.White;
            this.invitesButton.DisabledState.CustomBorderColor = System.Drawing.Color.White;
            this.invitesButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.invitesButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invitesButton.FillColor = System.Drawing.Color.White;
            this.invitesButton.FocusedColor = System.Drawing.Color.White;
            this.invitesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invitesButton.ForeColor = System.Drawing.Color.White;
            this.invitesButton.HoverState.FillColor = System.Drawing.Color.White;
            this.invitesButton.HoverState.Image = global::JobApp.Properties.Resources.invitefill;
            this.invitesButton.Image = global::JobApp.Properties.Resources.invite;
            this.invitesButton.ImageSize = new System.Drawing.Size(35, 35);
            this.invitesButton.Location = new System.Drawing.Point(219, 3);
            this.invitesButton.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.invitesButton.Name = "invitesButton";
            this.invitesButton.PressedColor = System.Drawing.Color.White;
            this.invitesButton.Size = new System.Drawing.Size(45, 45);
            this.invitesButton.TabIndex = 12;
            this.invitesButton.Click += new System.EventHandler(this.invitesButton_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.DisabledState.FillColor = System.Drawing.Color.White;
            this.buttonMinimize.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FillColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.HoverState.BorderColor = System.Drawing.Color.White;
            this.buttonMinimize.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.buttonMinimize.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonMinimize.HoverState.Image = global::JobApp.Properties.Resources.Minimize_Windowfill;
            this.buttonMinimize.Image = global::JobApp.Properties.Resources.Minimize_Window;
            this.buttonMinimize.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonMinimize.Location = new System.Drawing.Point(736, 2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.PressedColor = System.Drawing.Color.White;
            this.buttonMinimize.Size = new System.Drawing.Size(28, 28);
            this.buttonMinimize.TabIndex = 18;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonClose.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.buttonClose.DisabledState.FillColor = System.Drawing.Color.White;
            this.buttonClose.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.buttonClose.FillColor = System.Drawing.Color.Transparent;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.BorderColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.FillColor = System.Drawing.Color.White;
            this.buttonClose.HoverState.Image = global::JobApp.Properties.Resources.Close_Windowfill;
            this.buttonClose.Image = global::JobApp.Properties.Resources.Close_Window;
            this.buttonClose.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonClose.Location = new System.Drawing.Point(770, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.PressedColor = System.Drawing.Color.White;
            this.buttonClose.Size = new System.Drawing.Size(28, 28);
            this.buttonClose.TabIndex = 16;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // EmployerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployerForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button buttonMinimize;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button accountButton;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private Guna.UI2.WinForms.Guna2Button resumesButton;
        private Guna.UI2.WinForms.Guna2Button statementsButton;
        private Guna.UI2.WinForms.Guna2Button invitesButton;
    }
}