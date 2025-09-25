using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Teacher : Human
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short teacher_id { get; set; }
        [Required]
        public DateOnly work_since { get; set; }
        [Required]
        [Display(Name = "Ставка")]
        public decimal rate { get; set; }
    }
}
