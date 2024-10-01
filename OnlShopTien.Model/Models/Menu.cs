using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlShopTien.Model.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Url { get; set; }

        public int? DisplayOrders { get; set; }

        [Required]
        public int GroupID { get; set; }
        [ForeignKey ("GroupID")]
        public virtual MenuGroup MenuGroup { get; set; }
        public string Target { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}