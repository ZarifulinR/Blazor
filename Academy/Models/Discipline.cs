using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Academy.Models
{
    public class Discipline
    {
        [Key]   
        public short discipline_id {  get; set; }
        public string? discipline_name { get; set; }
        public int number_of_lessons { get; set; }  

    }
}
