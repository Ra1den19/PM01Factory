using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileJob
{
    [Table("responses")]
    public class Response : BaseModel
    {
        [PrimaryKey("response_id", false)]
        public int ResponseId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("vacancy_id")]
        public int VacancyId { get; set; }

        [Column("response_date")]
        public DateTime ResponseDate { get; set; }
    }
}
