using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models
{
    [Table("Room")]
    public class Rooms
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(50), Required]
        public string RoomName { get; set; }
        [StringLength(100), Required]
        public string Address { get; set; }
        [Required]
        public decimal Price { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(20)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(20)]
        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual ICollection<Categorys> Categorys { get; set; }

        public Rooms()
        {
            Categorys = new HashSet<Categorys>();
        }
    }
}
