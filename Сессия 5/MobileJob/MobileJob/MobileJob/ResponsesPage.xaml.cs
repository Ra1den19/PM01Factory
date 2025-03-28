using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResponsesPage : ContentPage
    {
        public ObservableCollection<ResponseItem> Responses { get; set; }
        public ResponsesPage()
        {
            InitializeComponent();
            Responses = new ObservableCollection<ResponseItem>();
            responsesCollectionView.ItemsSource = Responses;
            LoadResponses();
        }

        private async Task LoadResponses()
        {
            try
            {
                loadingIndicator.IsRunning = true;
                loadingIndicator.IsVisible = true;

                Responses.Clear();

                var supabase = await SupabaseHelper.GetClient();

                // Получение данных
                var responses = await supabase
                    .From<Response>()
                    .Where(x => x.UserId == MainPage.CurrentUserId)
                    .Get();

                var vacancies = await supabase
                    .From<Vacancy>()
                    .Get();

                var companies = await supabase
                    .From<Company>()
                    .Get();

                // Заполнение коллекции
                foreach (var response in responses.Models)
                {
                    var vacancy = vacancies.Models.FirstOrDefault(v => v.VacancyId == response.VacancyId);
                    if (vacancy != null)
                    {
                        var company = companies.Models.FirstOrDefault(c => c.CompanyId == vacancy.CompanyId);
                        string companyName = company?.CompanyName ?? "Неизвестная компания";

                        Responses.Add(new ResponseItem
                        {
                            ResponseId = response.ResponseId,
                            VacancyTitle = vacancy.VacancyTitle,
                            CompanyName = companyName,
                            ResponseDate = response.ResponseDate
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", $"Ошибка при загрузке откликов: {ex.Message}", "OK");
            }
            finally
            {
                // Скрыть индикатор загрузки
                loadingIndicator.IsRunning = false;
                loadingIndicator.IsVisible = false;
            }
        }


        public class ResponseItem
        {
            public int ResponseId { get; set; }
            public string VacancyTitle { get; set; }
            public string CompanyName { get; set; }
            public DateTime ResponseDate { get; set; }
        }
    }
}