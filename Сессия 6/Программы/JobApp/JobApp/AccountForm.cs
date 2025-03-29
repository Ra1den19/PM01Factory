using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApp
{
    public partial class AccountForm : Form
    {
        public byte[] currentPhoto;
        public AccountForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        public async void LoadUserData()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var user = await supabase
                    .From<User>()
                    .Where(x => x.UserId == AuthForm.CurrentUserId)
                    .Single();

                if (user != null)
                {
                    string fullName = $"{user.LastName ?? ""} {user.FirstName ?? ""} {user.MiddleName ?? ""}".Trim();
                    if (string.IsNullOrEmpty(fullName))
                        fullName = "ФИО не указано";

                    labelFIO.Text = fullName;
                    labelUsername.Text = user.Username ?? "Не указано";
                    labelPassword.Text = user.Password ?? "Не указан";
                    labelPhone.Text = user.Phone ?? "Не указано";
                    labelEmail.Text = user.Email ?? "Не указано";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string TestFormatFullName(string lastName, string firstName, string middleName)
        {
            string fullName = $"{lastName ?? ""} {firstName ?? ""} {middleName ?? ""}".Trim();
            return string.IsNullOrEmpty(fullName) ? "ФИО не указано" : fullName;
        }

        public void TestSetLabelText(string fullName, string username, string password, string phone, string email)
        {
            labelFIO.Text = string.IsNullOrEmpty(fullName) ? "ФИО не указано" : fullName;
            labelUsername.Text = username ?? "Не указано";
            labelPassword.Text = password ?? "Не указан";
            labelPhone.Text = phone ?? "Не указано";
            labelEmail.Text = email ?? "Не указано";
        }
    }
}
