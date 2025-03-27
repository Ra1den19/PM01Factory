using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApp
{
    [Table("job_seeker_applications")]
    public class JobSeekerApplication : BaseModel
    {
        [PrimaryKey("job_seeker_application_id", false)]
        public int JobSeekerApplicationId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("resume_id")]
        public int ResumeId { get; set; }

        [Column("application_date")]
        public DateTime ApplicationDate { get; set; }

        [Column("application_status")]
        public string ApplicationStatus { get; set; }
    }
}
