using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace JobApp
{
    public partial class StatementsInspectorForm : Form
    {
        public StatementsInspectorForm()
        {
            InitializeComponent();
            LoadEmployerApplications();
            LoadApplications();
        }

        private async void LoadEmployerApplications()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var applications = await supabase
                    .From<EmployerApplication>()
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
                dataGridEmp.DataSource = table;

                if (dataGridEmp.Columns.Contains("ID заявки"))
                    dataGridEmp.Columns["ID заявки"].Visible = false;

                if (dataGridEmp.Columns.Contains("Дата заявки"))
                    dataGridEmp.Columns["Дата заявки"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявлений работодателя: {ex.Message}");
            }
        }

        private async void LoadApplications()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var applications = await supabase
                    .From<JobSeekerApplication>()
                    .Get();

                var resumes = await supabase
                    .From<Resume>()
                    .Get();

                var table = new DataTable();
                table.Columns.Add("ID заявки", typeof(int));
                table.Columns.Add("Резюме", typeof(string));
                table.Columns.Add("Дата публикации", typeof(DateTime));
                table.Columns.Add("Статус", typeof(string));

                foreach (var application in applications.Models)
                {
                    var resume = resumes.Models.FirstOrDefault(r => r.ResumeId == application.ResumeId);
                    string resumeTitle = resume?.Title ?? "Неизвестное резюме";

                    table.Rows.Add(
                        application.JobSeekerApplicationId,
                        resumeTitle,
                        application.ApplicationDate,
                        application.ApplicationStatus
                    );
                }

                dataGridJS.DataSource = table;

                if (dataGridJS.Columns.Contains("ID заявки"))
                    dataGridJS.Columns["ID заявки"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}");
            }
        }

        private async void deniedJSButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли выделенные строки
                if (dataGridJS.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Пожалуйста, выберите резюме");
                    return;
                }

                // Получаем выделенную строку
                var selectedRow = dataGridJS.SelectedRows[0];

                // Получаем идентификатор заявки из таблицы
                if (!int.TryParse(selectedRow.Cells["ID заявки"].Value?.ToString(), out int applicationId))
                {
                    MessageBox.Show("Ошибка: не удалось получить ID заявки");
                    return;
                }

                // Получаем клиент Supabase
                var supabase = await SupabaseHelper.GetClient();
                if (supabase == null)
                {
                    MessageBox.Show("Не удалось подключиться к серверу. Проверьте подключение к интернету.");
                    return;
                }

                // Получаем информацию о заявке, чтобы узнать ID резюме
                var application = await supabase
                    .From<JobSeekerApplication>()
                    .Where(a => a.JobSeekerApplicationId == applicationId)
                    .Single();

                if (application == null)
                {
                    MessageBox.Show("Ошибка: не удалось найти заявку в базе данных");
                    return;
                }

                int resumeId = application.ResumeId;

                // Устанавливаем новые статусы
                string resumeStatus = "Закрыто";
                string applicationStatus = "Отклонено";

                // Обновляем резюме
                var resumeResponse = await supabase
                    .From<Resume>()
                    .Where(r => r.ResumeId == resumeId)
                    .Set(r => r.Status, resumeStatus)
                    .Update();

                // Обновляем заявку
                var applicationResponse = await supabase
                    .From<JobSeekerApplication>()
                    .Where(a => a.JobSeekerApplicationId == applicationId)
                    .Set(a => a.ApplicationStatus, applicationStatus)
                    .Update();

                MessageBox.Show("Заявление успешно отклонено!");

                // Обновляем данные в таблице
                LoadApplications();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обработке:\n{ex.Message}\n\nПодробности:\n{ex.StackTrace}");
            }
        }

        private async void approveJSButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли выделенные строки
                if (dataGridJS.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Пожалуйста, выберите резюме");
                    return;
                }

                // Получаем выделенную строку
                var selectedRow = dataGridJS.SelectedRows[0];

                // Получаем идентификатор заявки из таблицы
                if (!int.TryParse(selectedRow.Cells["ID заявки"].Value?.ToString(), out int applicationId))
                {
                    MessageBox.Show("Ошибка: не удалось получить ID заявки");
                    return;
                }

                // Получаем клиент Supabase
                var supabase = await SupabaseHelper.GetClient();
                if (supabase == null)
                {
                    MessageBox.Show("Не удалось подключиться к серверу. Проверьте подключение к интернету.");
                    return;
                }

                // Получаем информацию о заявке, чтобы узнать ID резюме
                var application = await supabase
                    .From<JobSeekerApplication>()
                    .Where(a => a.JobSeekerApplicationId == applicationId)
                    .Single();

                if (application == null)
                {
                    MessageBox.Show("Ошибка: не удалось найти заявку в базе данных");
                    return;
                }

                int resumeId = application.ResumeId;

                // Устанавливаем новые статусы
                string resumeStatus = "Открыто";
                string applicationStatus = "Одобрено";

                // Обновляем резюме
                var resumeResponse = await supabase
                    .From<Resume>()
                    .Where(r => r.ResumeId == resumeId)
                    .Set(r => r.Status, resumeStatus)
                    .Update();

                // Обновляем заявку
                var applicationResponse = await supabase
                    .From<JobSeekerApplication>()
                    .Where(a => a.JobSeekerApplicationId == applicationId)
                    .Set(a => a.ApplicationStatus, applicationStatus)
                    .Update();

                MessageBox.Show("Заявление успешно одобрено!");

                // Обновляем данные в таблице
                LoadApplications();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обработке:\n{ex.Message}\n\nПодробности:\n{ex.StackTrace}");
            }
        }

        private async void deniedEmpButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли выделенные строки
                if (dataGridEmp.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Пожалуйста, выберите заявку для одобрения");
                    return;
                }

                // Получаем выделенную строку
                var selectedRow = dataGridEmp.SelectedRows[0];

                // Получаем идентификатор заявки из таблицы
                if (!int.TryParse(selectedRow.Cells["ID заявки"].Value?.ToString(), out int applicationId))
                {
                    MessageBox.Show("Ошибка: не удалось получить ID заявки");
                    return;
                }

                // Получаем клиент Supabase
                var supabase = await SupabaseHelper.GetClient();
                if (supabase == null)
                {
                    MessageBox.Show("Не удалось подключиться к серверу. Проверьте подключение к интернету.");
                    return;
                }

                // Получаем информацию о заявке, чтобы узнать ID вакансии
                var application = await supabase
                    .From<EmployerApplication>()
                    .Where(a => a.EmployerApplicationId == applicationId)
                    .Single();

                if (application == null)
                {
                    MessageBox.Show("Ошибка: не удалось найти заявку в базе данных");
                    return;
                }

                int vacancyId = application.VacancyId;

                // Устанавливаем новые статусы
                string vacancyStatus = "Закрыта";
                string applicationStatus = "Отклонено";

                // Обновляем вакансию
                var vacancyResponse = await supabase
                    .From<Vacancy>()
                    .Where(v => v.VacancyId == vacancyId)
                    .Set(v => v.Status, vacancyStatus)
                    .Update();

                // Обновляем заявку
                var applicationResponse = await supabase
                    .From<EmployerApplication>()
                    .Where(a => a.EmployerApplicationId == applicationId)
                    .Set(a => a.ApplicationStatus, applicationStatus)
                    .Update();

                MessageBox.Show("Заявка работодателя успешно одобрена!");

                // Обновляем данные в таблице
                await Task.Run(() => LoadEmployerApplications());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обработке:\n{ex.Message}\n\nПодробности:\n{ex.StackTrace}");
            }
        }

        private async void approveEmpButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли выделенные строки
                if (dataGridEmp.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Пожалуйста, выберите заявку для одобрения");
                    return;
                }

                // Получаем выделенную строку
                var selectedRow = dataGridEmp.SelectedRows[0];

                // Получаем идентификатор заявки из таблицы
                if (!int.TryParse(selectedRow.Cells["ID заявки"].Value?.ToString(), out int applicationId))
                {
                    MessageBox.Show("Ошибка: не удалось получить ID заявки");
                    return;
                }

                // Получаем клиент Supabase
                var supabase = await SupabaseHelper.GetClient();
                if (supabase == null)
                {
                    MessageBox.Show("Не удалось подключиться к серверу. Проверьте подключение к интернету.");
                    return;
                }

                // Получаем информацию о заявке, чтобы узнать ID вакансии
                var application = await supabase
                    .From<EmployerApplication>()
                    .Where(a => a.EmployerApplicationId == applicationId)
                    .Single();

                if (application == null)
                {
                    MessageBox.Show("Ошибка: не удалось найти заявку в базе данных");
                    return;
                }

                int vacancyId = application.VacancyId;

                // Устанавливаем новые статусы
                string vacancyStatus = "Открыта";
                string applicationStatus = "Одобрено";

                // Обновляем вакансию
                var vacancyResponse = await supabase
                    .From<Vacancy>()
                    .Where(v => v.VacancyId == vacancyId)
                    .Set(v => v.Status, vacancyStatus)
                    .Update();

                // Обновляем заявку
                var applicationResponse = await supabase
                    .From<EmployerApplication>()
                    .Where(a => a.EmployerApplicationId == applicationId)
                    .Set(a => a.ApplicationStatus, applicationStatus)
                    .Update();

                MessageBox.Show("Заявка работодателя успешно одобрена!");

                // Обновляем данные в таблице
                await Task.Run(() => LoadEmployerApplications());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обработке:\n{ex.Message}\n\nПодробности:\n{ex.StackTrace}");
            }
        }
    }
}
