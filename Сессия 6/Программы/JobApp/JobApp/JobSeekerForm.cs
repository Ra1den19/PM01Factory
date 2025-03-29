using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApp
{
    public partial class JobSeekerForm : Form
    {
        public JobSeekerForm()
        {
            InitializeComponent();
            homeButton.MouseEnter += Button_MouseEnter;
            homeButton.MouseLeave += Button_MouseLeave;

            vacanciesButton.MouseEnter += Button_MouseEnter;
            vacanciesButton.MouseLeave += Button_MouseLeave;

            statementsButton.MouseEnter += Button_MouseEnter;
            statementsButton.MouseLeave += Button_MouseLeave;

            responsesButton.MouseEnter += Button_MouseEnter;
            responsesButton.MouseLeave += Button_MouseLeave;

            accountButton.MouseEnter += Button_MouseEnter;
            accountButton.MouseLeave += Button_MouseLeave;

            Home();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            HomeJobSeekerForm ccf = new HomeJobSeekerForm();
            ccf.TopLevel = false;
            ccf.FormBorderStyle = FormBorderStyle.None;
            ccf.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ccf);
            ccf.Show();
        }

        private void Home()
        {
            HomeJobSeekerForm ccf = new HomeJobSeekerForm();
            ccf.TopLevel = false;
            ccf.FormBorderStyle = FormBorderStyle.None;
            ccf.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ccf);
            ccf.Show();
        }

        private void vacanciesButton_Click(object sender, EventArgs e)
        {
            VacanciesJobSeekerForm vac = new VacanciesJobSeekerForm();
            vac.TopLevel = false;
            vac.FormBorderStyle = FormBorderStyle.None;
            vac.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(vac);
            vac.Show();
        }

        private void statementsButton_Click(object sender, EventArgs e)
        {
            StatementsJobSeekerForm statements = new StatementsJobSeekerForm();
            statements.TopLevel = false;
            statements.FormBorderStyle = FormBorderStyle.None;
            statements.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(statements);
            statements.Show();
        }

        private void responsesButton_Click(object sender, EventArgs e)
        {
            ResponsesJobSeekerForm responses = new ResponsesJobSeekerForm();
            responses.TopLevel = false;
            responses.FormBorderStyle = FormBorderStyle.None;
            responses.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(responses);
            responses.Show();
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
