using Supabase.Gotrue;
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
    public partial class ResponsesJobSeekerForm : Form
    {
        public ResponsesJobSeekerForm()
        {
            InitializeComponent();
            LoadResponses();
        }

        private async void LoadResponses()
        {
            try
            {
                var supabase = await SupabaseHelper.GetClient();

                var responses = await supabase
                    .From<Response>()
                    .Where(x => x.UserId == AuthForm.CurrentUserId)
                    .Get();

                var vacancies = await supabase
                    .From<Vacancy>()
                    .Get();

                var companies = await supabase
                    .From<Company>()
                    .Get();

                var table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("Вакансия", typeof(string));
                table.Columns.Add("Компания", typeof(string));
                table.Columns.Add("Дата отклика", typeof(DateTime));

                foreach (var response in responses.Models)
                {
                    var vacancy = vacancies.Models.FirstOrDefault(v => v.VacancyId == response.VacancyId);
                    if (vacancy != null)
                    {
                        var company = companies.Models.FirstOrDefault(c => c.CompanyId == vacancy.CompanyId);
                        string companyName = company?.CompanyName ?? "Неизвестная компания";

                        table.Rows.Add(
                            response.ResponseId,
                            vacancy.VacancyTitle,
                            companyName,
                            response.ResponseDate
                        );
                    }
                }

                dataGrid.DataSource = table;
                dataGrid.Columns["ID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке откликов: {ex.Message}");
            }
        }
    }
}
