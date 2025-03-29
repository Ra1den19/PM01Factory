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

        public async void saveButton_Click(object sender, EventArgs e)
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

        public void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }










        public Func<string, string, MessageBoxButtons, MessageBoxIcon, DialogResult> TestMessageBoxShow { get; set; }
        = (msg, caption, buttons, icon) => MessageBox.Show(msg, caption, buttons, icon);

        public void TestValidateRequiredFields()
        {
            string companyName = textComName.Text.Trim();
            string vacancyTitle = textName.Text.Trim();
            string specialization = textSpec.Text.Trim();

            if (string.IsNullOrEmpty(companyName) || string.IsNullOrEmpty(vacancyTitle) || string.IsNullOrEmpty(specialization))
            {
                TestMessageBoxShow(
                    "Пожалуйста, заполните обязательные поля",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
        }

        public Company TestCreateCompanyModel()
        {
            return new Company
            {
                CompanyName = textComName.Text.Trim(),
                CompanyAddress = textComAddress.Text.Trim(),
                CompanyEmail = textComMail.Text.Trim(),
                CompanyPhone = textComPhone.Text.Trim()
            };
        }

        public Vacancy TestCreateVacancyModel(int companyId)
        {
            return new Vacancy
            {
                UserId = AuthForm.CurrentUserId,
                CompanyId = companyId,
                VacancyTitle = textName.Text.Trim(),
                Specialization = textSpec.Text.Trim(),
                WorkExperience = textOpyt.Text.Trim(),
                WorkSchedule = textGraph.Text.Trim(),
                Salary = textSal.Text.Trim(),
                Education = textObr.Text.Trim(),
                PublicationDate = DateTime.Now,
                Status = "Закрыта"
            };
        }

        public EmployerApplication TestCreateApplicationModel(int vacancyId)
        {
            return new EmployerApplication
            {
                VacancyId = vacancyId,
                UserId = AuthForm.CurrentUserId,
                ApplicationDate = DateTime.Now,
                ApplicationStatus = "Рассматривается"
            };
        }

        public Func<Company, Exception> TestInsertCompany { get; set; }

        public void TestSaveCompanyAndVacancy()
        {
            try
            {
                var company = TestCreateCompanyModel();
                TestInsertCompany(company); // Намеренно вызовем ошибку

                // Эти строки не должны выполняться
                var vacancy = TestCreateVacancyModel(company.CompanyId);
                var application = TestCreateApplicationModel(vacancy.VacancyId);
            }
            catch (Exception ex)
            {
                TestMessageBoxShow(
                    $"Ошибка при создании: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                throw; // Намеренно пробрасываем исключение дальше
            }
        }
    }
}
