using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MobileJob
{
    public partial class MainPage : ContentPage
    {
        public static int CurrentUserId
        {
            get => Preferences.Get("CurrentUserId", -1);
            private set => Preferences.Set("CurrentUserId", value);
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string login = usernameEntry.Text?.Trim();
            string password = passwordEntry.Text;

            // Валидация полей
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                await DisplayAlert("Ошибка", "Введите логин и пароль", "OK");
                return;
            }


            try
            {
                // Аутентификация через Supabase
                var supabase = await SupabaseHelper.GetClient();
                var response = await supabase
                    .From<User>()
                    .Where(x => x.Username == login && x.Password == password)
                    .Single();

                if (response != null)
                {
                    // Сохраняем ID пользователя (можно использовать Preferences или SecureStorage)
                    Preferences.Set("CurrentUserId", response.UserId);

                    // Открываем соответствующую страницу
                    await OpenRoleSpecificPage(response.Role);
                }
                else
                {
                    await DisplayAlert("Ошибка", "Неверный логин или пароль", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", $"Ошибка авторизации: {ex.Message}", "OK");
            }
            finally
            {
                loginButton.IsEnabled = true;
            }
        }

        private async Task OpenRoleSpecificPage(string role)
        {
            Page pageToOpen = null;

            switch (role)
            {
                case "Соискатель":
                    pageToOpen = new JobSeekerPage();
                    break;
                case "Работодатель":
                    pageToOpen = new EmployerPage();
                    break;
                case "Инспектор":
                    pageToOpen = new InspectorPage();
                    break;
                default:
                    await DisplayAlert("Ошибка", "Неизвестная роль пользователя", "OK");
                    return;
            }

            // Закрываем текущую страницу и открываем новую
            await Navigation.PushAsync(pageToOpen);

            // Если нужно модальное окно (аналог ShowDialog):
            // await Navigation.PushModalAsync(new NavigationPage(pageToOpen));
        }
    }
}
