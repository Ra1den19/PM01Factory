using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAppLibrary
{
    [Table("resumes")]
    public class Resume : BaseModel
    {
        [PrimaryKey("resume_id", false)]
        public int ResumeId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("desired_position")]
        public string DesiredPosition { get; set; }

        [Column("desired_salary")]
        public string DesiredSalary { get; set; }

        [Column("education")]
        public string Education { get; set; }

        [Column("city")]
        public string City { get; set; }

        [Column("work_schedule")]
        public string WorkSchedule { get; set; }

        [Column("professional_skills")]
        public string ProfessionalSkills { get; set; }

        [Column("educational_institution")]
        public string EducationalInstitution { get; set; }

        [Column("faculty")]
        public string Faculty { get; set; }

        [Column("specialization_education")]
        public string SpecializationEducation { get; set; }

        [Column("graduation_year")]
        public string GraduationYear { get; set; }

        [Column("work_start_date")]
        public string WorkStartDate { get; set; }

        [Column("work_end_date")]
        public string WorkEndDate { get; set; }

        [Column("previous_company")]
        public string PreviousCompany { get; set; }

        [Column("previous_position")]
        public string PreviousPosition { get; set; }

        [Column("responsibilities_achievements")]
        public string ResponsibilitiesAchievements { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("publication_date")]
        public DateTime PublicationDate { get; set; }
    }
}
