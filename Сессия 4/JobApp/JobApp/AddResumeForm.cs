using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supabase;

namespace JobApp
{
    public partial class AddResumeForm : Form
    {
        private Supabase.Client supabase;
        public AddResumeForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                string title = textName.Text.Trim();
                string desiredPosition = textDol.Text.Trim();
                string desiredSalary = textSal.Text.Trim();
                string education = textEdu.Text.Trim();
                string professionalSkills = textSkills.Text.Trim();
                string workSchedule = textGraph.Text.Trim();

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(desiredPosition))
                {
                    MessageBox.Show("Пожалуйста, заполните обязательные поля (Название и Желаемая должность)");
                    return;
                }

                int currentUserId = AuthForm.CurrentUserId;

                var newResume = new Resume
                {
                    UserId = currentUserId,
                    Title = title,
                    DesiredPosition = desiredPosition,
                    DesiredSalary = desiredSalary,
                    Education = education,
                    ProfessionalSkills = professionalSkills,
                    WorkSchedule = workSchedule,
                    PublicationDate = DateTime.Now,
                    Status = "Рассматривается"
                };

                var insertedResume = await supabase
                    .From<Resume>()
                    .Insert(newResume);

                var createdResume = insertedResume.Models.FirstOrDefault();
                if (createdResume == null)
                {
                    throw new Exception("Не удалось получить ID созданного резюме");
                }

                var newApplication = new JobSeekerApplication
                {
                    UserId = AuthForm.CurrentUserId,
                    ResumeId = createdResume.ResumeId,
                    ApplicationDate = DateTime.Now,
                    ApplicationStatus = "Черновик"
                };

                await supabase
                    .From<JobSeekerApplication>()
                    .Insert(newApplication);

                MessageBox.Show("Резюме и заявка успешно созданы!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании резюме: {ex.Message}");
            }
        }
    }
}
