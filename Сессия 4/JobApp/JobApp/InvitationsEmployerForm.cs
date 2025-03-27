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
    public partial class InvitationsEmployerForm : Form
    {
        public InvitationsEmployerForm()
        {
            InitializeComponent();
            LoadInvitations();
        }

        private async void LoadInvitations()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var invitations = await supabase
                    .From<Invitation>()
                    .Where(x => x.UserId == AuthForm.CurrentUserId)
                    .Get();

                var resumes = await supabase
                    .From<Resume>()
                    .Get();

                var companies = await supabase
                    .From<Company>()
                    .Get();

                var table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Резюме", typeof(string));
                table.Columns.Add("Должность", typeof(string));
                table.Columns.Add("Компания", typeof(string));
                table.Columns.Add("Дата приглашения", typeof(DateTime));
                table.Columns.Add("Статус", typeof(string));

                foreach (var invitation in invitations.Models)
                {
                    var resume = resumes.Models.FirstOrDefault(r => r.ResumeId == invitation.ResumeId);
                    if (resume != null)
                    {
                        var company = companies.Models.FirstOrDefault(c => c.CompanyId == invitation.UserId);
                        string companyName = company?.CompanyName ?? "Неизвестная компания";

                        table.Rows.Add(
                            invitation.InvitationId,
                            resume.Title,
                            resume.DesiredPosition,
                            companyName,
                            invitation.InvitationDate,
                            resume.Status
                        );
                    }
                }

                dataGrid.DataSource = table;
                dataGrid.Columns["ID"].Visible = false;
                dataGrid.Columns["Дата приглашения"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке приглашений: {ex.Message}");
            }
        }
    }
}
