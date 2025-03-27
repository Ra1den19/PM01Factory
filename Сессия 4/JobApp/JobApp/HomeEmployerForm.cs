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
    public partial class HomeEmployerForm : Form
    {
        public HomeEmployerForm()
        {
            InitializeComponent();
            LoadVacancies();
        }

        private void addVacancyButton_Click(object sender, EventArgs e)
        {
            AddVacancyForm addVacancyForm = new AddVacancyForm();
            addVacancyForm.ShowDialog();
        }

        private async void LoadVacancies()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var vacancies = await supabase
                    .From<Vacancy>()
                    .Where(x => x.UserId == AuthForm.CurrentUserId)
                    .Get();

                var table = new DataTable();

                table.Columns.Add("Название вакансии", typeof(string));
                table.Columns.Add("Компания", typeof(string));
                table.Columns.Add("Специализация", typeof(string));
                table.Columns.Add("Опыт работы", typeof(string));
                table.Columns.Add("Зарплата", typeof(string));
                table.Columns.Add("Образование", typeof(string));
                table.Columns.Add("График работы", typeof(string));
                table.Columns.Add("Статус", typeof(string));
                table.Columns.Add("Дата публикации", typeof(DateTime));

                foreach (var vacancy in vacancies.Models)
                {

                    var company = await supabase
                        .From<Company>()
                        .Where(x => x.CompanyId == vacancy.CompanyId)
                        .Single();

                    table.Rows.Add(
                        vacancy.VacancyTitle,
                        company?.CompanyName ?? "Не указано",
                        vacancy.Specialization,
                        vacancy.WorkExperience,
                        vacancy.Salary,
                        vacancy.Education,
                        vacancy.WorkSchedule,
                        vacancy.Status,
                        vacancy.PublicationDate
                    );
                }

                dataGrid.DataSource = table;

                dataGrid.Columns["Дата публикации"].DefaultCellStyle.Format = "dd.MM.yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке вакансий: {ex.Message}");
            }
        }
    }
}
