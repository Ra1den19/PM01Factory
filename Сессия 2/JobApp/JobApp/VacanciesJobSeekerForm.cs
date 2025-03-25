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
    public partial class VacanciesJobSeekerForm : Form
    {
        public VacanciesJobSeekerForm()
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
                table.Columns.Add("Город", typeof(string));
                table.Columns.Add("Зарплата", typeof(string));
                table.Columns.Add("Тип занятости", typeof(string));
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
                        vacancy.City,
                        vacancy.Salary,
                        vacancy.EmploymentType,
                        vacancy.WorkSchedule,
                        vacancy.PublicationDate,
                        vacancy.Status
                    );
                }

                dataGrid.DataSource = table;

                dataGrid.Columns["VacancyId"].Visible = false;

                responseButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке вакансий: {ex.Message}");
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                string status = selectedRow.Cells["Статус"].Value?.ToString();

                responseButton.Enabled = (status == "Открыта");
            }
            else
            {
                responseButton.Enabled = false;
            }
        }

        private async void responseButton_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите вакансию для отклика");
                return;
            }

            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var selectedRow = dataGrid.SelectedRows[0];
                int vacancyId = Convert.ToInt32(selectedRow.Cells["VacancyId"].Value);

                var newResponse = new Response
                {
                    UserId = AuthForm.CurrentUserId,
                    VacancyId = vacancyId,
                    ResponseDate = DateTime.Now
                };

                await supabase
                    .From<Response>()
                    .Insert(newResponse);

                MessageBox.Show("Ваш отклик успешно отправлен!");

                LoadVacancies();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке отклика: {ex.Message}");
            }
        }
    }
}
