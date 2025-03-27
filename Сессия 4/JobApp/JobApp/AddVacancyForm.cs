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
    public partial class AddVacancyForm : Form
    {
        public AddVacancyForm()
        {
            InitializeComponent();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                string companyName = textComName.Text.Trim();
                string companyAddress = textComAddress.Text.Trim();
                string companyEmail = textComMail.Text.Trim();
                string companyPhone = textComPhone.Text.Trim();

                string vacancyTitle = textName.Text.Trim();
                string specialization = textSpec.Text.Trim();
                string workExperience = textOpyt.Text.Trim();
                string workSchedule = textGraph.Text.Trim();
                string salary = textSal.Text.Trim();
                string education = textObr.Text.Trim();

                if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(vacancyTitle) || string.IsNullOrEmpty(specialization))
                {
                    MessageBox.Show("Пожалуйста, заполните обязательные поля");
                    return;
                }

                int currentUserId = AuthForm.CurrentUserId;

                var newCompany = new Company
                {
                    CompanyName = companyName,
                    CompanyAddress = companyAddress,
                    CompanyEmail = companyEmail,
                    CompanyPhone = companyPhone
                };

                var insertedCompany = await supabase
                    .From<Company>()
                    .Insert(newCompany);

                var createdCompany = insertedCompany.Models.FirstOrDefault();
                if (createdCompany == null)
                {
                    throw new Exception("Не удалось получить ID созданной компании");
                }

                var newVacancy = new Vacancy
                {
                    UserId = currentUserId,
                    CompanyId = createdCompany.CompanyId,
                    VacancyTitle = vacancyTitle,
                    Specialization = specialization,
                    WorkExperience = workExperience,
                    WorkSchedule = workSchedule,
                    Salary = salary,
                    Education = education,
                    PublicationDate = DateTime.Now,
                    Status = "Закрыта"
                };

                var insertedVacancy = await supabase
                    .From<Vacancy>()
                    .Insert(newVacancy);

                var createdVacancy = insertedVacancy.Models.FirstOrDefault();
                if (createdVacancy == null)
                {
                    throw new Exception("Не удалось получить ID созданной вакансии");
                }

                var newApplication = new EmployerApplication
                {
                    VacancyId = createdVacancy.VacancyId,
                    UserId = currentUserId,
                    ApplicationDate = DateTime.Now,
                    ApplicationStatus = "Рассматривается"
                };

                await supabase
                    .From<EmployerApplication>()
                    .Insert(newApplication);

                MessageBox.Show("Компания, вакансия и заявка работодателя успешно созданы!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании: {ex.Message}");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
