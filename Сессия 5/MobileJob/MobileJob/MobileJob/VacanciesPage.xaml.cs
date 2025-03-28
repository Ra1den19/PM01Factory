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
    public partial class VacanciesPage : ContentPage
    {
        private List<Vacancy> _allVacancies = new List<Vacancy>();
        public VacanciesPage()
        {
            InitializeComponent();
            LoadVacancies();
        }

        private async void LoadVacancies()
        {
            try
            {
                vacanciesList.IsRefreshing = true;

                var supabase = await SupabaseHelper.GetClient();

                var vacancies = await supabase
                    .From<Vacancy>()
                    .Get();

                var companies = await supabase
                .From<Company>()
                    .Get();

                _allVacancies = vacancies.Models.Select(vacancy =>
                {
                    var company = companies.Models.FirstOrDefault(c => c.CompanyId == vacancy.CompanyId);
                    return new Vacancy
                    {
                        VacancyId = vacancy.VacancyId,
                        CompanyId = company.CompanyId,
                        VacancyTitle = vacancy.VacancyTitle,
                        City = vacancy.City,
                        Specialization = vacancy.Specialization,
                        Salary = vacancy.Salary,
                        WorkSchedule = vacancy.WorkSchedule,
                        EmploymentType = vacancy.EmploymentType,
                        Education = vacancy.Education,
                        PublicationDate = vacancy.PublicationDate,
                        Status = vacancy.Status
                    };
                }).ToList();

                vacanciesList.ItemsSource = _allVacancies;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", $"Ошибка загрузки вакансий: {ex.Message}", "OK");
            }
            finally
            {
                vacanciesList.IsRefreshing = false;
            }
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = e.NewTextValue?.ToLower() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                vacanciesList.ItemsSource = _allVacancies;
                return;
            }

            vacanciesList.ItemsSource = _allVacancies.Where(v =>
                (v.VacancyTitle?.ToLower().Contains(searchText) ?? false) ||
                (v.Specialization?.ToLower().Contains(searchText) ?? false) ||
                (v.City?.ToLower().Contains(searchText) ?? false)
            ).ToList();
        }
    }
}