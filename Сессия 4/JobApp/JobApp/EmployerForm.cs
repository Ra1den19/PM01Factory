using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace JobApp
{
    public partial class EmployerForm : Form
    {
        public EmployerForm()
        {
            InitializeComponent();

            homeButton.MouseEnter += Button_MouseEnter;
            homeButton.MouseLeave += Button_MouseLeave;

            resumesButton.MouseEnter += Button_MouseEnter;
            resumesButton.MouseLeave += Button_MouseLeave;

            statementsButton.MouseEnter += Button_MouseEnter;
            statementsButton.MouseLeave += Button_MouseLeave;

            invitesButton.MouseEnter += Button_MouseEnter;
            invitesButton.MouseLeave += Button_MouseLeave;

            accountButton.MouseEnter += Button_MouseEnter;
            accountButton.MouseLeave += Button_MouseLeave;

            Home();
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button gunaButton)
            {
                gunaButton.Size = new Size(45, 45);
                gunaButton.ImageSize = new Size(45, 45);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2Button gunaButton)
            {
                gunaButton.Size = new Size(45, 45);
                gunaButton.ImageSize = new Size(35, 35);
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            AccountForm account = new AccountForm();
            account.TopLevel = false;
            account.FormBorderStyle = FormBorderStyle.None;
            account.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(account);
            account.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeEmployerForm homeForm = new HomeEmployerForm();
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void Home()
        {
            HomeEmployerForm homeForm = new HomeEmployerForm();
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void resumesButton_Click(object sender, EventArgs e)
        {
            ResumesEmployerForm resumesEmployerForm = new ResumesEmployerForm();
            resumesEmployerForm.TopLevel = false;
            resumesEmployerForm.FormBorderStyle = FormBorderStyle.None;
            resumesEmployerForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(resumesEmployerForm);
            resumesEmployerForm.Show();
        }

        private void statementsButton_Click(object sender, EventArgs e)
        {
            StatementsEmployerForm statements = new StatementsEmployerForm();
            statements.TopLevel = false;
            statements.FormBorderStyle = FormBorderStyle.None;
            statements.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(statements);
            statements.Show();
        }

        private void invitesButton_Click(object sender, EventArgs e)
        {
            InvitationsEmployerForm invitationsEmployerForm = new InvitationsEmployerForm();
            invitationsEmployerForm.TopLevel = false;
            invitationsEmployerForm.FormBorderStyle = FormBorderStyle.None;
            invitationsEmployerForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(invitationsEmployerForm);
            invitationsEmployerForm.Show();
        }

        private void info_MouseEnter(object sender, EventArgs e)
        {
            qr.Visible = true;
        }

        private void info_MouseLeave(object sender, EventArgs e)
        {
            qr.Visible = false;
        }
    }
}
