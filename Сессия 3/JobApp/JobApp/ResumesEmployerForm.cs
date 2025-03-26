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
    public partial class ResumesEmployerForm : Form
    {
        public ResumesEmployerForm()
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
                    .Get();

                var table = new DataTable();

                table.Columns.Add("ResumeId", typeof(int));
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
                        resume.ResumeId,
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
                dataGrid.Columns["ResumeId"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке резюме: {ex.Message}");
            }
        }

        private async void inviteButton_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите резюме для отправки приглашения");
                return;
            }

            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var selectedRow = dataGrid.SelectedRows[0];
                int resumeId = Convert.ToInt32(selectedRow.Cells["ResumeId"].Value);

                var newInvitation = new Invitation
                {
                    UserId = AuthForm.CurrentUserId,
                    ResumeId = resumeId,
                    InvitationDate = DateTime.Now
                };

                await supabase
                    .From<Invitation>()
                    .Insert(newInvitation);

                MessageBox.Show("Приглашение успешно отправлено!");

                LoadResumes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отправке приглашения: {ex.Message}");
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                string status = selectedRow.Cells["Статус"].Value?.ToString();

                inviteButton.Enabled = (status == "Открыто");
            }
            else
            {
                inviteButton.Enabled = false;
            }
        }
    }
}
