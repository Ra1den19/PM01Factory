using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobApp
{
    [Table("favorite_vacancies")]
    public class FavoriteVacancy : BaseModel
    {
        [PrimaryKey("favorite_vacancy_id", false)]
        public int FavoriteVacancyId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("vacancy_id")]
        public int VacancyId { get; set; }
    }
}
