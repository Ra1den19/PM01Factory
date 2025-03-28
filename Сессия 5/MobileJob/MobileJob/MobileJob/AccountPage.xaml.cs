using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
            LoadUserData();
        }

        private async void LoadUserData()
        {
            try
            {
                // Показываем индикатор загрузки (если необходимо)
                IsBusy = true;

                var supabase = await SupabaseHelper.GetClient();

                var user = await supabase
                    .From<User>()
                    .Where(x => x.UserId == MainPage.CurrentUserId)
                    .Single();

                if (user != null)
                {
                    // Форматирование ФИО
                    string fullName = $"{user.LastName ?? ""} {user.FirstName ?? ""} {user.MiddleName ?? ""}".Trim();
                    if (string.IsNullOrEmpty(fullName))
                        fullName = "ФИО не указано";

                    // Обновляем UI в потоке пользовательского интерфейса
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        labelFIO.Text = fullName;
                        labelUsername.Text = user.Username ?? "Не указано";
                        labelPassword.Text = user.Password ?? "Не указано";
                        labelPhone.Text = user.Phone ?? "Не указано";
                        labelEmail.Text = user.Email ?? "Не указано";
                    });
                }
                else
                {
                    // Если пользователь не найден, выводим сообщение
                    await DisplayAlert("Информация", "Данные пользователя не найдены", "OK");
                }
            }
            catch (Exception ex)
            {
                // Используем DisplayAlert вместо MessageBox.Show для Xamarin.Forms
                await DisplayAlert("Ошибка", $"Ошибка загрузки данных: {ex.Message}", "OK");
            }
            finally
            {
                // Скрываем индикатор загрузки
                IsBusy = false;
            }
        }
    }
}