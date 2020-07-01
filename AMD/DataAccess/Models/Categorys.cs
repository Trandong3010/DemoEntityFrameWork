using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataAccess.Models
{
    [Table("Category")]
    public class Categorys
    {
        [Key]
        public int Id { get; set; }
        [Required ,StringLength(100)]
        public string CategoryName { get; set; }
        [StringLength(100)]
        public string Description { get; set; }
        [StringLength(100)]
        public string  createdBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public Categorys() { }
    }
}
