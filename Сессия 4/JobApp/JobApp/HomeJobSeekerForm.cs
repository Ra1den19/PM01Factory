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
    public partial class HomeJobSeekerForm : Form
    {
        public HomeJobSeekerForm()
        {
            InitializeComponent();
            LoadResumes();
        }

        private async void LoadResumes()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();
                var resumes = await supabase
                    .From<Resume>()
                    .Where(x => x.UserId == AuthForm.CurrentUserId) 
                    .Get();

                var table = new DataTable();

                table.Columns.Add("Название", typeof(string));
                table.Columns.Add("Должность", typeof(string));
                table.Columns.Add("Зарплата", typeof(string));
                table.Columns.Add("Образование", typeof(string));
                table.Columns.Add("Навыки", typeof(string));
                table.Columns.Add("График", typeof(string));
                table.Columns.Add("Статус", typeof(string));
                table.Columns.Add("Дата публикации", typeof(DateTime));

                foreach (var resume in resumes.Models)
                {
                    table.Rows.Add(
                        resume.Title,
                        resume.DesiredPosition,
                        resume.DesiredSalary,
                        resume.Education,
                        resume.ProfessionalSkills,
                        resume.WorkSchedule,
                        resume.Status,
                        resume.PublicationDate
                    );
                }

                dataGrid.DataSource = table;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке резюме: {ex.Message}");
            }
        }

        private void addResumeButton_Click(object sender, EventArgs e)
        {
            AddResumeForm addResumeForm = new AddResumeForm();
            addResumeForm.ShowDialog();
        }
    }
}
