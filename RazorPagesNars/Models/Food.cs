using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RazorPagesNars.Models
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Date of Availability")]
        [DataType(DataType.Date)]
        public DateTime DateofAvailability { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
