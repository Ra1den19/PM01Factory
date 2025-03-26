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
    public partial class StatementsEmployerForm : Form
    {
        public StatementsEmployerForm()
        {
            InitializeComponent();
            LoadEmployerApplications();
        }

        private async void LoadEmployerApplications()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var applications = await supabase
                    .From<EmployerApplication>()
                    .Where(x => x.UserId == AuthForm.CurrentUserId)
                    .Get();

                var vacancies = await supabase
                    .From<Vacancy>()
                    .Get();

                var table = new DataTable();
                table.Columns.Add("ID заявки", typeof(int));
                table.Columns.Add("Вакансия", typeof(string));
                table.Columns.Add("Дата заявки", typeof(DateTime));
                table.Columns.Add("Статус", typeof(string));

                foreach (var application in applications.Models)
                {
                    var vacancy = vacancies.Models.FirstOrDefault(v => v.VacancyId == application.VacancyId);
                    string vacancyTitle = vacancy?.VacancyTitle ?? "Неизвестная вакансия";

                    table.Rows.Add(
                        application.EmployerApplicationId,
                        vacancyTitle,
                        application.ApplicationDate,
                        application.ApplicationStatus
                    );
                }

                dataGrid.DataSource = table;

                if (dataGrid.Columns.Contains("ID заявки"))
                    dataGrid.Columns["ID заявки"].Visible = false;

                if (dataGrid.Columns.Contains("Дата заявки"))
                    dataGrid.Columns["Дата заявки"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявлений работодателя: {ex.Message}");
            }
        }
    }
}
