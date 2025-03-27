using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApp
{
    [Table("employer_applications")]
    public class EmployerApplication : BaseModel
    {
        [PrimaryKey("employer_application_id", false)]
        public int EmployerApplicationId { get; set; }

        [Column("vacancy_id")]
        public int VacancyId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("application_date")]
        public DateTime ApplicationDate { get; set; }

        [Column("application_status")]
        public string ApplicationStatus { get; set; }
    }
}
