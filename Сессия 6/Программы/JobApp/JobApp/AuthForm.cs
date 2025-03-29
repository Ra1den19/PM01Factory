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
        

        public static int CurrentUserId { get; set; }
        public AuthForm()
        {
            InitializeComponent();
            
        }

        public void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void toggleSwitchPassword_CheckedChanged(object sender, EventArgs e)
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

        public async void SignInButton_Click(object sender, EventArgs e)
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

        public void OpenRoleSpecificForm(string role)
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

        public Form TestOpenRoleSpecificForm(string role)
        {
            switch (role)
            {
                case "Соискатель":
                    return new JobSeekerForm();
                case "Работодатель":
                    return new EmployerForm();
                case "Инспектор":
                    return new InspectorForm();
                default:
                    throw new ArgumentException("Неизвестная роль пользователя");
            }
        }
    }
}
