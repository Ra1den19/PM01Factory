using Supabase;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Supabase.Client;

namespace JobApp
{
    public partial class AuthForm : Form
    {
        

        public static int CurrentUserId { get; private set; }
        public AuthForm()
        {
            InitializeComponent();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toggleSwitchPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleSwitchPassword.Checked == true)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else if (toggleSwitchPassword.Checked == false) 
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private async void SignInButton_Click(object sender, EventArgs e)
        {
            string login = textLogin.Text.Trim();
            string password = textPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            try
            {
                var supabase = await SupabaseHelper.GetClient();
                var response = await supabase
                    .From<User>()
                    .Where(x => x.Username == login && x.Password == password)
                    .Single();

                if (response != null)
                {
                    CurrentUserId = response.UserId;
                    OpenRoleSpecificForm(response.Role);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка авторизации: {ex.Message}");
            }
        }

        private void OpenRoleSpecificForm(string role)
        {
            Form formToOpen = null;

            switch (role)
            {
                case "Соискатель":
                    formToOpen = new JobSeekerForm();
                    break;
                case "Работодатель":
                    formToOpen = new EmployerForm();
                    break;
                case "Инспектор":
                    formToOpen = new InspectorForm();
                    break;
                default:
                    MessageBox.Show("Неизвестная роль пользователя");
                    return;
            }

            formToOpen.ShowDialog();
        }
    }
}
