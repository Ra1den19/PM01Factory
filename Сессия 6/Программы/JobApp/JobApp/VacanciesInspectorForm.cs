using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApp
{
    public partial class VacanciesInspectorForm : Form
    {
        public VacanciesInspectorForm()
        {
            InitializeComponent();
            LoadVacancies();
        }

        private async void LoadVacancies()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var vacancies = await supabase
                    .From<Vacancy>()
                    .Get();

                var companies = await supabase
                    .From<Company>()
                    .Get();

                var table = new DataTable();

                table.Columns.Add("VacancyId", typeof(int));
                table.Columns.Add("Компания", typeof(string));
                table.Columns.Add("Название вакансии", typeof(string));
                table.Columns.Add("Специализация", typeof(string));
                table.Columns.Add("Зарплата", typeof(string));
                table.Columns.Add("Образование", typeof(string));
                table.Columns.Add("График работы", typeof(string));
                table.Columns.Add("Дата публикации", typeof(DateTime));
                table.Columns.Add("Статус", typeof(string));

                foreach (var vacancy in vacancies.Models)
                {
                    var company = companies.Models.FirstOrDefault(c => c.CompanyId == vacancy.CompanyId);
                    string companyName = company?.CompanyName ?? "Неизвестная компания";

                    table.Rows.Add(
                        vacancy.VacancyId,
                        companyName,
                        vacancy.VacancyTitle,
                        vacancy.Specialization,
                        vacancy.Salary,
                        vacancy.Education,
                        vacancy.WorkSchedule,
                        vacancy.PublicationDate,
                        vacancy.Status
                    );
                }

                dataGrid.DataSource = table;

                dataGrid.Columns["VacancyId"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке вакансий: {ex.Message}");
            }
        }
    }
}
