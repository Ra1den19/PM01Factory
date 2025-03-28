using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileJob
{
    [Table("users")]
    public class User : BaseModel
    {
        [PrimaryKey("user_id", false)]
        public int UserId { get; set; }

        [Column("photo")]
        public byte[] Photo { get; set; }

        [Column("username")]
        public string Username { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("role")]
        public string Role { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("middle_name")]
        public string MiddleName { get; set; }

        [Column("citizenship")]
        public string Citizenship { get; set; }

        [Column("birth_date")]
        public string BirthDate { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("marital_status")]
        public string MaritalStatus { get; set; }

        [Column("has_children")]
        public string HasChildren { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("registration_date")]
        public DateTime? RegistrationDate { get; set; }
    }
}
