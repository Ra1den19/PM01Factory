using System;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAppLibrary
{
    [Table("vacancies")]
    public class Vacancy : BaseModel
    {
        [PrimaryKey("vacancy_id", false)]
        public int VacancyId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("company_id")]
        public int CompanyId { get; set; }

        [Column("vacancy_title")]
        public string VacancyTitle { get; set; }

        [Column("specialization")]
        public string Specialization { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("for_students")]
        public string ForStudents { get; set; }

        [Column("work_experience")]
        public string WorkExperience { get; set; }

        [Column("employment_type")]
        public string EmploymentType { get; set; }

        [Column("part_time")]
        public string PartTime { get; set; }

        [Column("work_schedule")]
        public string WorkSchedule { get; set; }

        [Column("salary")]
        public string Salary { get; set; }

        [Column("education")]
        public string Education { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("publication_date")]
        public DateTime PublicationDate { get; set; }
    }
}
