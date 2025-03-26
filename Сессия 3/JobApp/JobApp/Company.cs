using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApp
{
    [Table("companies")]
    public class Company : BaseModel
    {
        [PrimaryKey("company_id", false)]
        public int CompanyId { get; set; }

        [Column("company_name")]
        public string CompanyName { get; set; }

        [Column("company_address")]
        public string CompanyAddress { get; set; }

        [Column("company_email")]
        public string CompanyEmail { get; set; }

        [Column("company_phone")]
        public string CompanyPhone { get; set; }
    }
}
