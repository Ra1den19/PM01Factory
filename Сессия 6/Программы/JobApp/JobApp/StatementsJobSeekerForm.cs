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
    public partial class StatementsJobSeekerForm : Form
    {
        public StatementsJobSeekerForm()
        {
            InitializeComponent();
            LoadApplications();
        }

        private async void LoadApplications()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var applications = await supabase
                    .From<JobSeekerApplication>()
                    .Where(x => x.UserId == AuthForm.CurrentUserId)
                    .Get();

                var resumes = await supabase
                    .From<Resume>()
                    .Where(r => r.UserId == AuthForm.CurrentUserId)
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

                dataGrid.DataSource = table;

                if (dataGrid.Columns.Contains("ID заявки"))
                    dataGrid.Columns["ID заявки"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке заявок: {ex.Message}");
            }
        }
    }
}
