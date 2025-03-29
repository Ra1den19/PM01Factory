using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApp
{
    public partial class InspectorForm : Form
    {
        public InspectorForm()
        {
            InitializeComponent();

            homeButton.MouseEnter += Button_MouseEnter;
            homeButton.MouseLeave += Button_MouseLeave;

            vacanciesButton.MouseEnter += Button_MouseEnter;
            vacanciesButton.MouseLeave += Button_MouseLeave;

            resumesButton.MouseEnter += Button_MouseEnter;
            resumesButton.MouseLeave += Button_MouseLeave;

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

        private void resumesButton_Click(object sender, EventArgs e)
        {
            ResumesInspectorForm ccf = new ResumesInspectorForm();
            ccf.TopLevel = false;
            ccf.FormBorderStyle = FormBorderStyle.None;
            ccf.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(ccf);
            ccf.Show();
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

        private void vacanciesButton_Click(object sender, EventArgs e)
        {
            VacanciesInspectorForm vcf = new VacanciesInspectorForm();
            vcf.TopLevel = false;
            vcf.FormBorderStyle = FormBorderStyle.None;
            vcf.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(vcf);
            vcf.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            StatementsInspectorForm statementsInspectorForm = new StatementsInspectorForm();
            statementsInspectorForm.TopLevel = false;
            statementsInspectorForm.FormBorderStyle = FormBorderStyle.None;
            statementsInspectorForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(statementsInspectorForm);
            statementsInspectorForm.Show();
        }

        private void Home()
        {
            StatementsInspectorForm statementsInspectorForm = new StatementsInspectorForm();
            statementsInspectorForm.TopLevel = false;
            statementsInspectorForm.FormBorderStyle = FormBorderStyle.None;
            statementsInspectorForm.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(statementsInspectorForm);
            statementsInspectorForm.Show();
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
