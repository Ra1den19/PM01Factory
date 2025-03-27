using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApp
{
    [Table("favorite_resumes")]
    public class FavoriteResume : BaseModel
    {
        [PrimaryKey("favorite_resume_id", false)]
        public int FavoriteResumeId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("resume_id")]
        public int ResumeId { get; set; }
    }
}
