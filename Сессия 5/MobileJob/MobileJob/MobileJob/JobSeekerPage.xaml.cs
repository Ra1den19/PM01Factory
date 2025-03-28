using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileJob
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JobSeekerPage : ContentPage
    {
        public JobSeekerPage()
        {
            InitializeComponent();
            LoadPage(new VacanciesPage());
        }

        private void LoadPage(ContentPage page)
        {
            ContentArea.Content = page.Content;
        }

        private void OnAccountClicked(object sender, EventArgs e)
        {
            LoadPage(new AccountPage());
        }

        private void OnVacanciesClicked(object sender, EventArgs e)
        {
            LoadPage(new VacanciesPage());
        }

        private void OnApplicationsClicked(object sender, EventArgs e)
        {
            LoadPage(new ApplicationsPage());
        }

        private void OnResponsesClicked(object sender, EventArgs e)
        {
            LoadPage(new ResponsesPage());
        }
    }
}