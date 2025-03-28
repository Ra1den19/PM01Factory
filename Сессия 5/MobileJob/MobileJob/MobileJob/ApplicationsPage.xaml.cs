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
    public partial class ApplicationsPage : ContentPage
    {
        public ObservableCollection<ApplicationItem> Applications { get; set; }
        public ApplicationsPage()
        {
            InitializeComponent();
            Applications = new ObservableCollection<ApplicationItem>();
            applicationsCollectionView.ItemsSource = Applications;
            LoadApplications();
        }

        private async Task LoadApplications()
        {
            try
            {
                // Показать индикатор загрузки
                loadingIndicator.IsRunning = true;
                loadingIndicator.IsVisible = true;

                // Очистка существующих данных
                Applications.Clear();

                var supabase = await SupabaseHelper.GetClient();

                var applications = await supabase
                    .From<JobSeekerApplication>()
                    .Where(x => x.UserId == MainPage.CurrentUserId)
                    .Get();

                var resumes = await supabase
                    .From<Resume>()
                    .Where(r => r.UserId == MainPage.CurrentUserId)
                    .Get();

                // Заполнение коллекции
                foreach (var application in applications.Models)
                {
                    var resume = resumes.Models.FirstOrDefault(r => r.ResumeId == application.ResumeId);
                    string resumeTitle = resume?.Title ?? "Неизвестное резюме";

                    Applications.Add(new ApplicationItem
                    {
                        ApplicationId = application.JobSeekerApplicationId,
                        ResumeTitle = resumeTitle,
                        ApplicationDate = application.ApplicationDate,
                        Status = application.ApplicationStatus
                    });
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", $"Ошибка при загрузке заявок: {ex.Message}", "OK");
            }
            finally
            {
                // Скрыть индикатор загрузки
                loadingIndicator.IsRunning = false;
                loadingIndicator.IsVisible = false;
            }
        }
    }

    public class ApplicationItem
    {
        public int ApplicationId { get; set; }
        public string ResumeTitle { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string Status { get; set; }
    }
}