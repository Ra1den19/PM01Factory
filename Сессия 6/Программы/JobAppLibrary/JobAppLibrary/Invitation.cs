using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobAppLibrary
{
    [Table("invitations")]
    public class Invitation : BaseModel
    {
        [PrimaryKey("invitation_id", false)]
        public int InvitationId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("resume_id")]
        public int ResumeId { get; set; }

        [Column("invitation_date")]
        public DateTime InvitationDate { get; set; }
    }
}
