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
        private byte[] currentPhoto;
        public AccountForm()
        {
            InitializeComponent();
            LoadUserData();
        }

        private async void LoadUserData()
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
    }
}
